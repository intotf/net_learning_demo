using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoHttpPost
{
    [Serializable]
    public class SelectModel
    {
        /// <summary>
        /// 下拉框的值
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// 下拉框文本
        /// </summary>
        public string Title { get; set; }


        
    }
}
