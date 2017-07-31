using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Library
{
    /// <summary>
    /// 定义简单构造函数
    /// 与多线程单例模式实现
    /// 单例模式 - 对象实例只会在程序中被实例外一次
    /// 单例模式 分为： 饿汉式、懒汉式
    /// </summary>
    public class DemoClass
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        private DemoClass()
        {
            Console.WriteLine("只会构造一次 DemoClass");
            Thread.Sleep(1000);
        }

        /// <summary>
        /// 定义要创建的对象
        /// </summary>
        private static DemoClass _DemoClass = null;

        /// <summary>
        /// 对象锁,静态属性
        /// </summary>
        private static object _DemoLock = new object();

        /// <summary>
        /// 防止外部多次实例外对象
        /// 双 if  加 lock 为懒汉式
        /// </summary>
        /// <returns></returns>
        public static DemoClass CreateDemoClass()
        {
            if (_DemoClass == null)
            {
                lock (_DemoLock)  //锁定后，多线程进入后，只会创建一次
                {
                    Console.WriteLine("等待锁");
                    if (_DemoClass == null)
                    {
                        _DemoClass = new DemoClass();
                    }
                }
            }
            return _DemoClass;

        }

        /// <summary>
        /// 对象方法-显示
        /// </summary>
        public static void Show()
        {
            Thread.Sleep(10);
            Console.WriteLine("DemoClass.Show 方法");
        }
    }
}
