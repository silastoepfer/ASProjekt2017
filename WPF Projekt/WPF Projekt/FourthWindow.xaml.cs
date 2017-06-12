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
    /// Interaktionslogik für FourthWindow.xaml
    /// </summary>
    public partial class FourthWindow : Window
    {
        public FourthWindow()
        {
            InitializeComponent();
        }

        private void B2Main_Click(object sender, RoutedEventArgs e)
        {
            StartWindow win1 = new StartWindow();
            win1.Show();
            this.Close();
        }

        private void closeapp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
