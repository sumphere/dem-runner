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

namespace dem_runner.Components
{
    /// <summary>
    /// Логика взаимодействия для Layout.xaml
    /// </summary>
    public partial class Layout : UserControl
    {
        public static readonly DependencyProperty ShowLoginButtonProperty =
            DependencyProperty.Register("ShowLoginButton", typeof(bool), typeof(Layout), new PropertyMetadata(false));
        public bool ShowLoginButton
        {
            get { return (bool)GetValue(ShowLoginButtonProperty); }
            set { SetValue(ShowLoginButtonProperty, value); }
        }
        public static readonly DependencyProperty ShowFullHeaderProperty =
            DependencyProperty.Register("ShowFullHeader", typeof(bool), typeof(Layout), new PropertyMetadata(false));
        public bool ShowFullHeader
        {
            get { return (bool)GetValue(ShowFullHeaderProperty); }
            set { SetValue(ShowFullHeaderProperty, value); }
        }
        public Layout()
        {
            InitializeComponent();
        }
    }
}
