using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HB.CusControls.Controls
{
    public class HBProgressBar : ProgressBar
    {

        static HBProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HBProgressBar), new FrameworkPropertyMetadata(typeof(HBProgressBar)));
        }

        #region 依赖属性
        /// <summary>
        /// 是否只读
        /// </summary>
        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsReadOnly.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(HBProgressBar), new PropertyMetadata(false));




        /// <summary>
        /// 当前数值
        /// </summary>
        public double CurrentValue
        {
            get { return (double)GetValue(CurrentValueProperty); }
            set { SetValue(CurrentValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentValueProperty =
            DependencyProperty.Register("CurrentValue", typeof(double), typeof(HBProgressBar), new PropertyMetadata(0));

        /// <summary>
        /// 当前值背景颜色
        /// </summary>
        public Brush ValueBackGroudColor
        {
            get { return (Brush)GetValue(ValueBackGroudColorProperty); }
            set { SetValue(ValueBackGroudColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ValueBackGroudColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueBackGroudColorProperty =
            DependencyProperty.Register("ValueBackGroudColor", typeof(Brush), typeof(HBProgressBar), new PropertyMetadata(0));

        #endregion
    }
}
