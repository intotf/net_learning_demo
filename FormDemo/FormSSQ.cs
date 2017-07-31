using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    public partial class FormSSQ : Form
    {
        /// <summary>
        /// 红球数值 33 个
        /// </summary>
        private string[] RedNum = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", 
                                    "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
                                    "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
                                    "31", "32", "33" };
        /// <summary>
        /// 蓝球随机数
        /// </summary>
        private string[] BlueNum = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", 
                                     "11", "12", "13", "14", "15", "16" };

        private bool IsRun = true;

        private List<string> lockNum = new List<string>();
        /// <summary>
        /// 随机数种子
        /// </summary>
        private int ranSeeds = 1;

        public FormSSQ()
        {
            InitializeComponent();
            this.btStop.Enabled = false;
            this.btParaStop.Enabled = false;
        }

        /// <summary>
        /// 多线程运行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.btStart.Enabled = false;
            this.btParaStart.Enabled = false;
            this.btParaStop.Enabled = false;
            TaskFactory taskFactory = new TaskFactory();
            var taskList = new List<Task>();
            this.IsRun = true;

            foreach (var item in this.BallPanel.Controls)
            {
                if (item is Label)
                {
                    var lb = (Label)item;
                    taskList.Add(taskFactory.StartNew(() => this.SetBallLb(lb)));
                }
            }
            this.btStop.Enabled = true;
            taskFactory.ContinueWhenAll(taskList.ToArray(), item =>
            {
                this.RunCallback();
            });
        }

        /// <summary>
        /// 设置球随机值
        /// </summary>
        /// <param name="lb"></param>
        private void SetBallLb(Label lb)
        {

            if (lb.Name.Contains("RedBall"))
            {
                while (this.IsRun)
                {
                    Thread.Sleep(1000);
                    Interlocked.Increment(ref this.ranSeeds);
                    Random ran = new Random(this.ranSeeds);   //随机
                    var index = ran.Next(0, this.RedNum.Length);
                    setLableText(lb, this.RedNum[index]);
                }
            }
            else if (lb.Name.Contains("BlueBall"))
            {
                while (this.IsRun)
                {
                    Thread.Sleep(1000);
                    Random ran = new Random();   //随机
                    var index = ran.Next(0, this.BlueNum.Length);
                    setLableText(lb, this.BlueNum[index]);
                }
            }

        }

        /// <summary>
        /// 设置文本的 Text
        /// </summary>
        /// <param name="lb"></param>
        /// <param name="msg"></param>
        private void setLableText(Label lb, string msg)
        {
            this.Invoke(new Action(() => lb.Text = msg));
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.btStop.Enabled = false;
            this.btStart.Enabled = true;
            this.btParaStart.Enabled = true;
            this.IsRun = false;
        }

        /// <summary>
        /// 多线程运行完后回调
        /// </summary>
        private void RunCallback()
        {
            string msg = "摇号结果为： 红球 {0} {1} {2} {3} {4} {5} 蓝球 {6}";
            msg = string.Format(msg, this.RedBall01.Text,
                this.RedBall02.Text,
                this.RedBall03.Text,
                this.RedBall04.Text,
                this.RedBall05.Text,
                this.RedBall06.Text,
                this.BlueBall.Text);
            MessageBox.Show(msg);
        }

        /// <summary>
        /// 并发执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.btStop.Enabled = false;
            this.btParaStart.Enabled = false;
            this.btStart.Enabled = false;
            this.IsRun = true;
            var act = new List<Action>();
            foreach (var item in this.BallPanel.Controls)
            {
                if (item is Label)
                {
                    var lb = (Label)item;
                    if (lb.Name.Contains("Ball"))
                    {
                        act.Add(() => Ran(lb));
                    }
                }
            }

            //当并行结束后，线程自动释放,所以使用线程完成后转到提示
            Task.Run(() =>
            {
                Parallel.Invoke(act.ToArray());
            }).GetAwaiter().OnCompleted(() => this.RunCallback());

            this.btParaStop.Enabled = true;
        }

        /// <summary>
        /// 执行指定的球变化
        /// </summary>
        private void Ran(Label lb)
        {
            while (this.IsRun)
            {
                Thread.Sleep(1000);
                Interlocked.Increment(ref this.ranSeeds);
                Random ran = new Random(this.ranSeeds);   //随机
                var index = ran.Next(0, this.RedNum.Length);
                var indexNum = this.RedNum[index];
                if (!this.lockNum.Contains(indexNum))
                {
                    setLockNum(indexNum);
                    setLableText(lb, this.RedNum[index]);
                }
            }
        }

        /// <summary>
        /// 锁定已选中的号码
        /// </summary>
        /// <param name="addNum"></param>
        private void setLockNum(string addNum)
        {
            lock (this.lockNum)
            {
                if (this.lockNum.Count <= 6)
                {
                    this.lockNum.Add(addNum);
                }
                else
                {
                    this.lockNum.Clear();
                }

            }
        }

        /// <summary>
        /// 并发停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.IsRun = false;
            this.btParaStop.Enabled = false;
            this.btParaStart.Enabled = true;
            this.btStart.Enabled = true;
            this.btStop.Enabled = false;
        }
    }
}
