using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfaceLib
{
    /// <summary>
    /// 汽车接口
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// 生产中国车
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        void MadeChinaCar<T>(T t) where T : ChinaCar;

        /// <summary>
        /// 生产德国车
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        void MadeGermanyCar<T>(T t) where T : GermanyCar;
    }
}
