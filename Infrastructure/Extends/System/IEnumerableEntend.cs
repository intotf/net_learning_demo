﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    /// <summary>
    /// 可迭代类扩展
    /// </summary>
    public static partial class IEnumerableEntend
    {
        /// <summary>
        /// 为Null则返回0条记录的迭代
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<T> NullThenEmpty<T>(this IEnumerable<T> source)
        {
            if (source != null)
            {
                return source;
            }
            return Enumerable.Empty<T>();
        }
    }
}
