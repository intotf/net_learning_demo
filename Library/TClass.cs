using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    /// <summary>
    /// 泛型常用类
    /// </summary>
    public class TClass
    {
        /// <summary>
        /// 1、泛型学习
        ///     调用方式：Fun<T>(t)
        /// </summary>
        /// <typeparam name="T">定义传入的对象类型</typeparam>
        /// <param name="t">对象</param>
        /// <returns></returns>
        public string GetGeneric<T>(T tParameter)
        {
            return string.Format("你输的值是：{0},类型为：{1}", tParameter.ToString(), tParameter.GetType());
        }

        /// <summary>
        /// 1、泛型学习
        ///     泛型约束：Fun<T>(t)
        /// </summary>
        /// <typeparam name="T">定义传入的对象类型</typeparam>
        /// <param name="t">对象</param>
        /// <returns></returns>
        public string GetGenericByModel<T>(T tParameter) where T : BaseCarModel
        {
            return string.Format("你输的值是：{0},类型为：{1}", tParameter.Brand, tParameter.GetType());
        }

        /// <summary>
        /// 有返回的泛型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        /// <returns></returns>
        public T GetByModel<T>(T tParameter) where T : BaseCarModel
        {
            return tParameter;
        }
    }
}
