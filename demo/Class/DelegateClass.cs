using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Reflection;
using interfaceLib;

namespace demo
{
    /// <summary>
    /// 委托类
    /// </summary>
    public class DelegateClass
    {
        /// <summary>
        /// 声名一个无返回的委托
        /// </summary>
        public delegate void modelDelegate(ChinaCar model);

        public void modelDeleegateFun(ChinaCar model)
        {
            Console.WriteLine("通过委托返回对象的名称：{0}", model.CarName);
        }


        /// <summary>
        /// 泛型委托,对T 约束必需继成 BaseCarModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="f"></param>
        /// <param name="t"></param>
        /// <param name="Model"></param>
        public void GenericFun<T>(Func<T> f, T Model) where T : BaseCarModel
        {
            Type type = Model.GetType();
            var propertys = type.GetProperties();
            Console.WriteLine("循环显示对象的所有属性及对应的类型");
            foreach (var item in propertys)
            {
                Console.WriteLine("对象名称:{0},类型为：{1},值为：{2}", item.Name, item.GetType(), item.GetValue(Model, null));
            }
        }
    }
}
