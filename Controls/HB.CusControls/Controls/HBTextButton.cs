using HB.CusControls.ElementUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HB.CusControls
{
    public class HBTextButton : Button
    {
        static HBTextButton()
        {
            ElementBase.SetDefalueStyle<HBTextButton>(DataContextProperty);
        }
    }
}
