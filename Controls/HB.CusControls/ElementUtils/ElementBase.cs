using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HB.CusControls.ElementUtils
{
    internal static class ElementBase
    {
        /// <summary>
        /// 设置默认样式
        /// </summary>
        /// <typeparam name="T">控件类型</typeparam>
        /// <param name="dp">DefaultStyleKeyProperty</param>
        internal static void SetDefalueStyle<T>(DependencyProperty dp)
        {
            dp.OverrideMetadata(typeof(T), new FrameworkPropertyMetadata(typeof(T)));
        }
    }
}
