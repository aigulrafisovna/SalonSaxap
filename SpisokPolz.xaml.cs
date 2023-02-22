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
    /// Логика взаимодействия для SpisokPolz.xaml
    /// </summary>
    public partial class SpisokPolz : Window
    {
        public SpisokPolz()
        {
            InitializeComponent();
            СалонкрасотыContext db = new СалонкрасотыContext();
            List<User> users = db.Users.ToList();
            DGridUser.ItemsSource = СалонкрасотыContext.GetContext().Users.ToList();
        }

        private void DGridUslugi_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
