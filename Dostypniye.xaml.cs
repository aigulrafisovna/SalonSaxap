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
    /// Логика взаимодействия для Dostypniye.xaml
    /// </summary>
    public partial class Dostypniye : Window
    {
        public Dostypniye()
        {
            InitializeComponent();
            СалонкрасотыContext db = new СалонкрасотыContext();
            List<Uslugi> uslugis = db.Uslugis.ToList();
            DGridUslugi.ItemsSource = СалонкрасотыContext.GetContext().Uslugis.ToList();
        }

      //  private object СалонкрасотыContext()
       // {
       //     throw new NotImplementedException();
       // }

        private void DGridUslugi_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnRez_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
