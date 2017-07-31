using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSSQ());

        }

        //    static async void Test()
        //    {
        //        var tasks = Enumerable.Range(0, 10).Select(i => RunAsTask());
        //        var result = await Task.WhenAll(tasks);
        //    }



        //    static bool isRun = false;

        //    static Result Run(object context)
        //    {
        //        while (isRun)
        //        {
        //        }
        //        return 10;
        //    }

        //    static Task<Result> RunAsTask(object context)
        //    {
        //        return Task.Run(() => Run(context));
        //    }



        //}

        //class Result
        //{
        //    public int Value;

        //    public object context;
        //}
    }
}
