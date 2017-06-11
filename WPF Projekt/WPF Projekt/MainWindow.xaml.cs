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


namespace WPF_Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>

    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        //public Point MousePosition { get; private set; }



        //private bool clicado = false;
        //private Point lm = new Point();

        //void PnMouseDown(object sender, MouseEventArgs e)
        //{
        //    clicado = true;
        //    this.lm = MousePosition;
        //}

        //void PnMouseUp(object sender, MouseEventArgs e)
        //{
        //    clicado = false;
        //}

        //void PnMouseMove(object sender, MouseEventArgs e)
        //{
        //    if (clicado)
        //    {
        //        this.Left += (MousePosition.X - this.lm.X);
        //        this.Top += (MousePosition.Y - this.lm.Y);
        //        this.lm = MousePosition;
        //    }
        //}

        private void Fragebogen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void config_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("dgfdfg");

            SecondWindow win2 = new SecondWindow();
            win2.Show();
            this.Close();

            //var newWindow = new SecondWindow();
            //newWindow.Show();
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            //starten des ausgewählten fragenkataloges

            ThirdWindow win3 = new ThirdWindow();
            win3.Show();
            this.Close();
        }

        private void closeapp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
