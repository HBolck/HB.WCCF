using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.ViewControls;

namespace HB.CusControlMainApp
{
    public class MainWindowModel : ViewModelBase
    {
        private string _timePickerTime;
        public string TimePickerTime { get { return _timePickerTime; } set { _timePickerTime = value; OnPropertyChanged("TimePickerTime"); } }
    }
}
