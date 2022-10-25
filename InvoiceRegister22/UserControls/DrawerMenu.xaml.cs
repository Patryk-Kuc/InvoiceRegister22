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

namespace InvoiceRegister22.UserControls
{
    /// <summary>
    /// Interaction logic for DrawerMenu.xaml
    /// </summary>
    public partial class DrawerMenu : UserControl
    {
        public static readonly DependencyProperty TextMenuProperty = DependencyProperty.Register("TextMenu", typeof(string), typeof(DrawerMenu));
        
        public string TextMenu
        {
            get { return (string)GetValue(TextMenuProperty); }
            set { SetValue(TextMenuProperty, value); }
        }

        public DrawerMenu()
        {
            InitializeComponent();
        }


    }
}
