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

namespace SalonSaxap
{
    /// <summary>
    /// Логика взаимодействия для Kabinet.xaml
    /// </summary>
    public partial class Kabinet : Window
    {
        public Kabinet()
        {
            InitializeComponent();
        }


        private void button_actual_Click_1(object sender, RoutedEventArgs e)
        {
            Dostypniye dos = new Dostypniye();
            this.Close();
            dos.Show();
        }

        private void button_zapis_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
