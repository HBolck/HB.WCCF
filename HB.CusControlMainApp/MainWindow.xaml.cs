using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HB.CusControlMainApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainWindowModel();
            DataContext = _vm;
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void test_Click(object sender, RoutedEventArgs e)
        {
            _vm.TimePickerTime = timepicker.Date.ToString("D") + timepicker.TimeSpan.ToString();
        }
    }
}
