using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Diagnostics;
using Model;
using Library;
using System.Threading.Tasks;
using System.Threading;

namespace demo
{

    class cp<TCar> : IEqualityComparer<TCar> where TCar : BaseCarModel
    {
        public bool Equals(TCar x, TCar y)
        {
            return true;
        }

        public int GetHashCode(TCar obj)
        {
            return obj.Id.GetHashCode();
        }
    }



    class Program
    {

        public delegate void ss<T>(T t);

        private Stopwatch stopwatch = new Stopwatch();
        public static DemoClass demoClass = DemoClass.CreateDemoClass();


        //public bool cpModel(ChinaCar old, ChinaCar newObj)
        //{
        //    1.cpInt(2);
        //    "1".cpStringd("3");

        //    return old.Id == newObj.Id;
        //}



        static void Main(string[] args)
        {
            HashSet<char> hash = new HashSet<char>();
            string str = "abcdefgabhib";
            foreach (var item in str)
            {
                hash.Add(item);
            }

            //Console.Title = "C# 学习 Demo";//设置窗口标题

            var model = new ChinaCar()
            {
                Brand = "大众",
                CarName = "我的小车",
                Color = "Red",
                Id = 1,
                MadeTime = DateTime.Now,
                SeatNum = 5
            };

            var model2 = new ChinaCar()
            {
                Brand = "大众1",
                CarName = "我的小车1",
                Color = "Redsss",
                Id = 5,
                MadeTime = DateTime.Now,
                SeatNum = 5
            };


            var h = new HashSet<ChinaCar>(new cp<ChinaCar>());
            h.Add(model2);
            h.Add(model);

            var tClass = new TClass();
            var carClass = new CarClass();
            //carClass.MadeChinaCar(model);


            //Console.WriteLine(tClass.GetGeneric(model).ToString());
            ////强制泛型类型  tClass.getTToString<int>(1)
            //Console.WriteLine(tClass.GetGeneric<int>(1));
            //Console.WriteLine(tClass.GetGenericByModel(model));

            //ParallelClass.ParallelInvokeMethod();

            //TaskClass.TaskRun();

            //ParallelClass.ParallelTask();


            //var delegateClass = new DelegateClass();
            //var delega = new DelegateClass();
            //var method = new DelegateClass.modelDelegate(delega.modelDeleegateFun);
            //method.Invoke(model);

            //delega.GenericFun(() => tClass.GetByModel(model), model);

            for (int i = 0; i < 5; i++)
            {
                Task.Run(() =>
                {
                    DemoClass.Show();
                });
            }

            var listTask = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                listTask.Add(Task.Run(() =>
                    {
                        DemoClass.Show();
                    }));
            }
            Task.WaitAll(listTask.ToArray(), 1000);

            Console.Read();
        }


    }
}
