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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double Radians;
            try
            {
                Radians = Convert.ToDouble(textBox1.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Отстутствует или ошибочное значение радианы", "Ошибка");
                return;
            }
            double Dedgrees = Radians *180 / 3.14159265359;
            textBox2.Text = Math.Round(Dedgrees, 2).ToString();
        }
    }
}
