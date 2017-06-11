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
    /// Interaktionslogik für SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void config_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new StartWindow();
            newWindow.Close();
        }

        private void endconfig_Click(object sender, RoutedEventArgs e)
        {
            //zurück ins MainWindow

            StartWindow win1 = new StartWindow();
            win1.Show();
            this.Close();
        }

    }
}
