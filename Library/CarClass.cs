using interfaceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Library
{
    public class CarClass : ICar
    {
        public void MadeChinaCar<T>(T t) where T : ChinaCar
        {
            Console.WriteLine("正在生产中国车 [{0}]   颜色{1}   ID：{2}", t.Brand, t.Color, t.Id);
        }

        public void MadeGermanyCar<T>(T t) where T : GermanyCar
        {
            Console.WriteLine("正在生产德国车 [{0}]   颜色{1}   ID：{2}", t.Brand, t.Color, t.Id);
        }
    }
}
