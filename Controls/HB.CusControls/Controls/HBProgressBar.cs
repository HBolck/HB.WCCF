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
        /// 进度值颜色
        /// </summary>
        public Brush ValueBackGroud
        {
            get { return (Brush)GetValue(ValueBackGroudProperty); }
            set { SetValue(ValueBackGroudProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ValueBackGroud.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueBackGroudProperty =
            DependencyProperty.Register("ValueBackGroud", typeof(Brush), typeof(HBProgressBar), 
                new PropertyMetadata(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00CC33"))));



        /// <summary>
        /// 进度值圆角
        /// </summary>
        public double ValueCornerRadius
        {
            get { return (double)GetValue(ValueCornerRadiusProperty); }
            set { SetValue(ValueCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ValueCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueCornerRadiusProperty =
            DependencyProperty.Register("ValueCornerRadius", typeof(double), typeof(HBProgressBar), new PropertyMetadata(0.0));



        public HBProgressBar()
        {
        }

        #endregion


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
        }
    }
}
