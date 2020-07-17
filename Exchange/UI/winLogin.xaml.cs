using HandyControl.Controls;
using HandyControl.Tools;
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

namespace Exchange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class winLogin : HandyControl.Controls.Window
    {
        public winLogin()
        {
            InitializeComponent();
            ConfigHelper.Instance.SetWindowDefaultStyle();
        }
    }
}
