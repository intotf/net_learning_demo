using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeDemo
{
    [DemoAttribute]
    [Demo()]
    [Demo("info")]
    [Demo("info", info = "info")]
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    /// <summary>
    /// 特性在不影响类型封装的前提示，给类额外增加信息/行为，比如写日志
    /// AOP ： 面向切面编程，就是在不影响原来类型封装的前下面，额外的切入新的功能
    /// 修饰特性
    /// AllowMultiple=true  是否可以重复使用
    /// AttributeTargets.Enum 可以对枚举使用该特性, AttributeTargets.All 所有
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DemoAttribute : Attribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DemoAttribute()
        {

        }

        public DemoAttribute(string info)
        {
            this.info = info;
        }

        /// <summary>
        /// 显示，private set 只可当前类进行 set
        /// </summary>
        public string info { get; set; }
    }
}
