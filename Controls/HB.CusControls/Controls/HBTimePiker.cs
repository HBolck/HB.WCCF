using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HB.CusControls.Controls
{
    public class HBTimePiker : Control
    {

        static HBTimePiker()
        {
            ElementUtils.ElementBase.SetDefalueStyle<HBTimePiker>(DefaultStyleKeyProperty);
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
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(HBTimePiker), new PropertyMetadata(false));



        /// <summary>
        /// 时间
        /// </summary>
        public TimeSpan TimeSpan
        {
            get { return (TimeSpan)GetValue(TimeSpanProperty); }
            set { SetValue(TimeSpanProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TimeSpan.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TimeSpanProperty =
            DependencyProperty.Register("TimeSpan", typeof(TimeSpan), typeof(HBTimePiker), new PropertyMetadata(new TimeSpan(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second)));



        /// <summary>
        /// 日期时间（不包含时分秒）
        /// </summary>
        public DateTime Date
        {
            get { return (DateTime)GetValue(DateTimeProperty); }
            set { SetValue(DateTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DateTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateTimeProperty =
            DependencyProperty.Register("DateTime", typeof(DateTime), typeof(HBTimePiker), new PropertyMetadata(DateTime.Now));



        /// <summary>
        /// 小时
        /// </summary>
        public int Hour
        {
            get { return (int)GetValue(HourProperty); }
            set { SetValue(HourProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Hour.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HourProperty =
            DependencyProperty.Register("Hour", typeof(int), typeof(HBTimePiker), new PropertyMetadata(DateTime.Now.Hour));


        /// <summary>
        /// 分钟
        /// </summary>
        public int Minute
        {
            get { return (int)GetValue(MinuteProperty); }
            set { SetValue(MinuteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minute.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinuteProperty =
            DependencyProperty.Register("Minute", typeof(int), typeof(HBTimePiker), new PropertyMetadata(DateTime.Now.Minute));


        /// <summary>
        /// 秒
        /// </summary>
        public int Second
        {
            get { return (int)GetValue(SecondProperty); }
            set { SetValue(SecondProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Second.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondProperty =
            DependencyProperty.Register("Second", typeof(int), typeof(HBTimePiker), new PropertyMetadata(DateTime.Now.Second));

        #endregion

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);



            //更新小时
            if (e.Property == HourProperty)
            {
                int hour = (int)e.NewValue;
                if (hour == 24)
                {
                    SetValue(HourProperty, 23);
                }
                else if (hour == -1)
                {
                    SetValue(HourProperty, 0);
                }
                SetValue(TimeSpanProperty, new TimeSpan(Hour, TimeSpan.Minutes, TimeSpan.Seconds));
            }
            //更新分钟
            else if (e.Property == MinuteProperty)
            {
                int minute = (int)e.NewValue;
                switch (minute)
                {
                    case -1:
                        if (Hour == 0)
                        {
                            SetValue(MinuteProperty, 0);
                        }
                        else
                        {
                            SetValue(MinuteProperty, 59);
                            SetValue(HourProperty, Hour - 1);
                        }
                        break;
                    case 60:
                        if (Hour == 24)
                        {
                            SetValue(MinuteProperty, 59);
                        }
                        else
                        {
                            SetValue(MinuteProperty, 0);
                            SetValue(HourProperty, Hour + 1);
                        }
                        break;
                }
                SetValue(TimeSpanProperty, new TimeSpan(TimeSpan.Hours, Minute, TimeSpan.Seconds));
            }
            //设置秒
            else if (e.Property == SecondProperty)
            {
                int second = (int)e.NewValue;
                switch (second)
                {
                    case -1:
                        if (Minute > 0 || Hour > 0)
                        {
                            SetValue(SecondProperty, 59);
                            SetValue(MinuteProperty, Minute - 1);
                        }
                        else
                        {
                            SetValue(SecondProperty, 0);
                        }
                        break;
                    case 60:
                        SetValue(SecondProperty, 0);
                        SetValue(MinuteProperty, Minute + 1);
                        break;
                }
                SetValue(TimeSpanProperty, new TimeSpan(TimeSpan.Hours, TimeSpan.Minutes, Second));
            }
            else if (e.Property == TimeSpanProperty)
            {
                TimeSpan timeSpan = (TimeSpan)e.NewValue;
                SetValue(HourProperty, timeSpan.Hours);
                SetValue(MinuteProperty, timeSpan.Minutes);
                SetValue(SecondProperty, timeSpan.Seconds);
            }
            else if (e.Property == DateTimeProperty)
            {
                DateTime dateTime = (DateTime)e.NewValue;
                SetValue(DateTimeProperty, new DateTime(dateTime.Year, dateTime.Month, dateTime.Day).Date);
            }
        }
    }
}
