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

namespace SalonSaxap
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

        private void log_ent_TextChanged(object sender, TextChangedEventArgs e)
        {


        }


       private void pass_ent_TextChanged(object sender, RoutedEventArgs e)
       {

       }

     

        private void button_reg_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            this.Close();
            reg.Show();
        }

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            string login = log.Text.Trim();
            string password = pass.Password.Trim();
            if (login.Length < 5)
            {
                log.ToolTip = "Поле введено не корректно!";
                log.Background = Brushes.DarkRed;
            }
            else
            {
                log.ToolTip = "";
                log.Background = Brushes.Transparent;

                if (password.Length < 5)
                {
                    pass.ToolTip = "Поле введено не корректно!";
                    pass.Background = Brushes.DarkRed;
                }
                else
                {
                    pass.ToolTip = "";
                    pass.Background = Brushes.Transparent;

                    using (СалонкрасотыContext context = new СалонкрасотыContext())
                    {
                        foreach (User authUser in context.Users)
                        {
                            if (log.Text == authUser.Login && pass.Password == authUser.Password && authUser.Role == "Администратор")
                            {
                                if (authUser.Role == "Администратор")
                                {
                                    Admin admin = new Admin();
                                    admin.Show();
                                    Hide();
                                    return;
                                }
                            }

                            else if (log.Text == authUser.Login && pass.Password == authUser.Password && authUser.Role == "Пользователь")
                            {
                                if (authUser.Role == "Пользователь")
                                {
                                    //DKabinet = (int)authUser.idUser;
                                    Kabinet userForm = new Kabinet();
                                    userForm.Show();
                                    Hide();
                                    return;

                                }
                            }


                        }

                    }
                    MessageBox.Show("Invalid login or password!");

                }

            }
        }
    }
}
