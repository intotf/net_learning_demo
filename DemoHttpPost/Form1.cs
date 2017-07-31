using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHttpPost
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 默认文件路径
        /// </summary>
        private string bastDataPath = Directory.GetCurrentDirectory() + "\\Data";

        /// <summary>
        /// Post 提交类型
        /// </summary>
        private IEnumerable<SelectModel> postType = default(PostType).GetValueDisplays().Select(item => new SelectModel { Value = item.Key.GetHashCode(), Title = item.Value });

        /// <summary>
        /// Post 提交语言
        /// </summary>
        //private IEnumerable<SelectModel> langType = Encoding.GetEncodings().Select(item => new SelectModel { Value = item.CodePage, Title = item.DisplayName });
        private IEnumerable<SelectModel> langType = default(LanguageType).GetValueDisplays().Select(item => new SelectModel { Value = item.Key.GetHashCode(), Title = item.Value });

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializePage();
        }

        /// <summary>
        /// 初始化页面
        /// </summary>
        private void InitializePage()
        {


            this.setStatusTxt("正在加载...");
            this.cbLangType.Items.Clear();
            this.cbPostType.Items.Clear();
            this.cbQueryList.Items.Clear();

            //检查Data 目录是否存在
            FileHelper.CreateDirectory(bastDataPath);

            //初始化提交方式
            this.cbPostType.DisplayMember = "Title";
            this.cbPostType.Items.AddRange(postType.ToArray());
            var postTypeList = postType.ToList();
            this.cbPostType.SelectedIndex = postTypeList.IndexOf(postTypeList.Where(item => item.Title == ConfigModel.DefaultPostType).FirstOrDefault());
            //this.cbPostType.SelectedIndexChanged += new EventHandler(cbPostType_SelectedIndexChanged);

            //初始化提交编码
            this.cbLangType.DisplayMember = "Title";
            this.cbLangType.Items.AddRange(langType.ToArray());
            var langTypeList = langType.ToList();
            this.cbLangType.SelectedIndex = langTypeList.IndexOf(langTypeList.Where(item => item.Title == ConfigModel.DefaultLanguage).FirstOrDefault());

            //var Encodings =  Encoding.GetEncodings();
            //this.cbLangType.DisplayMember = "DisplayName";
            //this.cbLangType.Items.AddRange(Encodings);



            //初始化查询历史
            var dataList = FileHelper.GetFileNames(bastDataPath).Select(item => new { FileName = item.Replace(bastDataPath, "").Replace("\\", "") }).ToArray();
            this.cbQueryList.DisplayMember = "FileName";
            this.cbQueryList.Items.AddRange(dataList);
            this.cbQueryList.SelectedIndex = (dataList.Length > 0 ? 0 : -1);
            this.setStatusTxt("初始化完成.");
        }

        /// <summary>
        /// 添加文件到列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var dgvIndex = this.dgvFiles.Rows.Add();
                this.dgvFiles.Rows[dgvIndex].Cells[0].Value = dialog.FileName;
            }
        }

        /// <summary>
        /// 删除文件列表中的记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;
            if (CIndex == 1)
            {
                if (e.RowIndex >= 0)
                {
                    this.dgvFiles.Rows.RemoveAt(e.RowIndex);  //删除当前行
                }
            }
        }

        /// <summary>
        /// 提交参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubmit_Click(object sender, EventArgs e)
        {
            var model = GetParameterModel();
            if (model == null)
                return;
            var lType = Encoding.GetEncoding(model.langType.GetFieldDisplay());

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (model.postType == PostType.Post)
            {
                Task.Run(() =>
                    this.SubmitPostHttp(model.postUrl.AbsoluteUri, model.postBody, lType, model.fileList)
                ).ContinueWith((item) =>
                {
                    stopWatch.Stop();
                    setStatusTxt(string.Format("总共用时：{0}ms", stopWatch.ElapsedMilliseconds.ToString()));
                });
            }
            else
            {
                Task.Run(() =>
                    this.SubmitGetHttp(model.postUrl.AbsoluteUri, model.postBody, lType)
                ).ContinueWith((item) =>
                {
                    stopWatch.Stop();
                    setStatusTxt(string.Format("总共用时：{0}ms", stopWatch.ElapsedMilliseconds.ToString()));
                });
            }
        }

        /// <summary>
        /// 设置状态栏文本
        /// </summary>
        /// <param name="msg"></param>
        private void setStatusTxt(string msg)
        {
            this.Invoke(new Action(() =>
            {
                this.toolStripStatusLabel1.Text = msg;
            }));
        }

        /// <summary>
        /// 获取介面提交参数实体
        /// </summary>
        private ParameterModel GetParameterModel()
        {
            if (!this.tbUrl.Text.IsUrl())
            {
                MessageBox.Show("提交地址必需为一个完整的Url");
                return null;
            }
            var model = new ParameterModel();
            List<string> listFile = new List<string>();

            foreach (DataGridViewRow item in this.dgvFiles.Rows)
            {
                var tempFile = item.Cells[0].Value.ToString();//假设你的mac列在第二列
                if (!listFile.Contains(tempFile))
                {
                    listFile.Add(tempFile);
                }
            }
            var langType = this.cbLangType.SelectedItem.ToOfType<SelectModel>();
            var postType = this.cbPostType.SelectedItem.ToOfType<SelectModel>();
            model.fileList = GetFileList();
            model.postBody = this.tbDataBody.Text;
            model.langType = (LanguageType)langType.Value;
            model.postType = (PostType)postType.Value;
            model.postUrl = this.tbUrl.Text.ToUri();
            return model;
        }


        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <returns></returns>
        private List<string> GetFileList()
        {
            var fileList = new List<string>();
            for (var i = 0; i < this.dgvFiles.Rows.Count; i++)
            {
                fileList.Add(this.dgvFiles.Rows[i].Cells[0].Value.ToOfType<string>());
            }
            return fileList;
        }

        /// <summary>
        /// Post提交数据
        /// </summary>
        /// <param name="url">提交地址</param>
        /// <param name="body">提交内容</param>
        /// <param name="langType">提交编码</param>
        /// <param name="fileList">文件列表</param>
        private void SubmitPostHttp(string url, string body, Encoding langType, List<string> fileList)
        {
            var clientResult = DateTime.Now.ToDateTimeString() + "\r\n";
            using (var client = new HttpClient())
            {
                try
                {
                    if (fileList.Count() > 0)
                    {
                        var form = new HttpClient.MultipartForm();
                        foreach (var file in fileList)
                        {
                            string fileName = file.Substring(file.LastIndexOf('\\') + 1);
                            form.AddFile(fileName, file);
                            var parArr = body.Split('&');
                            foreach (var item in parArr)
                            {
                                if (!item.IsNullOrEmpty())
                                {
                                    var items = item.Split('=');
                                    form.Add(items[0], items[1]);
                                }
                            }
                        }
                        clientResult += client.HttpPost(url, form, langType);
                    }
                    else
                    {
                        clientResult += client.HttpPost(url, body, langType);
                    }
                }
                catch (Exception ex)
                {
                    clientResult += ex.Message;
                    setStatusTxt("异常：" + ex.Message);
                }
                tbAppendText(this.tbResult, clientResult + "\r\n");
            }
        }

        /// <summary>
        /// 设置委托设置文本框内容
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="value"></param>
        private void tbAppendText(TextBox tb, string value)
        {
            this.Invoke(new Action(() =>
            {
                tb.AppendText(value);
                tb.ScrollToCaret();
            }));
        }

        /// <summary>
        /// Get提交数据
        /// </summary>
        /// <param name="url"></param>
        /// <param name="body"></param>
        /// <param name="langType"></param>
        private void SubmitGetHttp(string url, string body, Encoding langType)
        {
            var clientResult = DateTime.Now.ToDateTimeString() + "\r\n";
            using (var client = new HttpClient())
            {
                try
                {
                    clientResult += client.HttpGet(url, body, langType);
                }
                catch (Exception ex)
                {
                    clientResult += ex.Message;
                    setStatusTxt("异常：" + ex.Message);
                }
                tbAppendText(this.tbResult, clientResult + "\r\n");
            }
        }

        /// <summary>
        /// 保存查询条件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSave_Click(object sender, EventArgs e)
        {
            var model = GetParameterModel();
            if (model == null)
                return;

            var modelByte = ByteConvertHelper.T2Bytes<ParameterModel>(model);
            //设置保存文件的格式  
            saveFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
            saveFileDialog1.InitialDirectory = bastDataPath;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //使用“另存为”对话框中输入的文件名实例化FileStream对象  
                FileStream myStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //使用FileStream对象实例化BinaryWriter二进制写入流对象  
                BinaryWriter myWriter = new BinaryWriter(myStream);
                //以二进制方式向创建的文件中写入内容  
                myWriter.Write(modelByte);
                //关闭当前二进制写入流  
                myWriter.Close();
                //关闭当前文件流  
                myStream.Close();
            }
            MessageBox.Show("保存成功.");
            InitializePage();
        }

        /// <summary>
        /// 加载参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLoding_Click(object sender, EventArgs e)
        {
            var filePath = bastDataPath + "\\" + this.cbQueryList.Text;
            var fileByte = FileHelper.FileToBytes(filePath);
            var model = ByteConvertHelper.Bytes2T<ParameterModel>(fileByte);

            var a = new SelectModel { Value = model.postType.GetHashCode(), Title = model.postType.GetFieldDisplay() };
            var b = new SelectModel { Value = model.postType.GetHashCode(), Title = model.postType.GetFieldDisplay() };

            if (model != null)
            {
                this.tbDataBody.Text = model.postBody;
                this.tbUrl.Text = model.postUrl.AbsoluteUri;
                var postTypeList = postType.ToList();
                this.cbPostType.SelectedIndex = postTypeList.IndexOf(postTypeList.Where(item => item.Value == model.postType.GetHashCode()).FirstOrDefault());

                var langTypeList = langType.ToList();
                this.cbLangType.SelectedIndex = langTypeList.IndexOf(langTypeList.Where(item => item.Value == model.langType.GetHashCode()).FirstOrDefault());
                this.dgvFiles.Rows.Clear();
                foreach (var item in model.fileList)
                {
                    var dgvIndex = this.dgvFiles.Rows.Add();
                    this.dgvFiles.Rows[dgvIndex].Cells[0].Value = item;
                }

            }
        }

        /// <summary>
        /// 提交方式选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbPostType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbPostType.SelectedItem != null)
            {
                var postTypeSelect = this.cbPostType.SelectedItem.ToOfType<SelectModel>();
                var postType = (PostType)postTypeSelect.Value;
                if (postType == PostType.Get)
                {
                    btAddFile.Enabled = false;
                }
                else
                {
                    btAddFile.Enabled = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true; //将Handled设置为true，指示已经处理过KeyPress事件
                this.btSave.PerformClick(); //执行单击保存按钮
            }
        }
    }
}
