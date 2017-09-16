using interfaceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Collections;

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

    public class CarList : IEnumerable<CarList>
    {
        public CarList[] carList { get; set; }

        public string name { get; set; }

        public CarList(string name)
        {
            this.name = name;
        }

        public IEnumerable<CarList> GetEnumerableByName()
        {
            if (string.IsNullOrEmpty(this.name))
            {
                yield return new CarList("没有名字");
                yield return new CarList("不知道什么意思");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    yield return new CarList(i.ToString() + this.name);
                }
            }

        }

        public IEnumerable<CarList> GetEnumerable()
        {
            foreach (var item in carList)
            {
                yield return item;
            }
        }

        IEnumerable System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerable();
        }
    }


}
