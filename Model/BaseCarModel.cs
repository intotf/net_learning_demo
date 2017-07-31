using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 静态类
    /// </summary>
    public abstract class BaseCarModel
    {
        //车辆ID
        public int Id { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        public int SeatNum { get; set; }

        /// <summary>
        /// 制作时间
        /// </summary>
        public DateTime MadeTime { get; set; }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
