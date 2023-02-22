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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void fam_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

      
        private void pochta_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void log_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void pass_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void button_registration_Click(object sender, RoutedEventArgs e)
        {
            string Login = log.Text.Trim();
            string Password = pass.Password.Trim();
            string Fullname = fam.Text.Trim();
            string Name = imya.Text.Trim();
            string Email = pochta.Text.Trim().ToLower();

            if (Login.Length < 5)
            {
                log.ToolTip = "Поле введено не корректно!";
                log.Background = Brushes.DarkRed;
            }
            else
            {
                log.ToolTip = "";
                log.Background = Brushes.Transparent;

                if (Password.Length < 5)
                {
                    pass.ToolTip = "Поле введено не корректно!";
                    pass.Background = Brushes.DarkRed;
                }
                else
                {
                    pass.ToolTip = "";
                    pass.Background = Brushes.Transparent;

                    if (Email.Length < 5)
                    {
                        pochta.ToolTip = "Поле введено не корректно!";
                        pochta.Background = Brushes.DarkRed;
                    }
                    else
                    {
                        pochta.ToolTip = "";
                        pochta.Background = Brushes.Transparent;

                        if (Name.Length < 5)
                        {
                            imya.ToolTip = "Поле введено не корректно!";
                            imya.Background = Brushes.DarkRed;
                        }
                        else
                        {
                            imya.ToolTip = "";
                            imya.Background = Brushes.Transparent;

                            if (Fullname.Length < 5)
                            {
                                fam.ToolTip = "Поле введено не корректно!";
                                fam.Background = Brushes.DarkRed;
                            }
                            else
                            {
                                fam.ToolTip = "";
                                fam.Background = Brushes.Transparent;

                                using (СалонкрасотыContext db = new СалонкрасотыContext())
                            {
                                var user = db.Users.FirstOrDefault(x => x.Login == log.Text || x.Password == pass.Password);
                                if (user != null)
                                {
                                    MessageBox.Show("Такой пользователь уже существует!");
                                }
                                User useradd = new User
                                {

                                    Login = log.Text,
                                    Password = pass.Password,
                                    Name = imya.Text,
                                    Fullname = fam.Text,
                                    Email = pochta.Text,

                                    Role = "Пользователь"
                                };
                                db.Users.Add(useradd);
                                db.SaveChanges();
                                MessageBox.Show("Рестрация прошла успешно!");
                                MainWindow mainWindow = new MainWindow();
                                mainWindow.Show();
                                Hide();
                            }

                        }
                    }
                }
            }
        }
    }
    }
}
