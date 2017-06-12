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
using System.Windows.Shapes;

namespace WPF_Projekt
{
    /// <summary>
    /// Interaktionslogik für ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }


        private void endtest_Click(object sender, RoutedEventArgs e)
        {
            FourthWindow win4 = new FourthWindow();
            win4.Show();
            this.Close();
        }

        private void closeapp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
