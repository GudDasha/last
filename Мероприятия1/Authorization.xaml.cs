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

namespace Мероприятия1
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            var user = Instance.db.Пользователи.Where(u=>u.уникальный_код == txtLogin.Text && u.пароль == pbPassword.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                Transfer.LoggedUser = user;
                switch (user.код_роли)
                {
                    //организатор
                    case 1:
                        ManagerNavigate.MainFrame.Navigate(new Organizer(user.ФИО));
                        break;
                    //модератор
                    case 2:
                        ManagerNavigate.MainFrame.Navigate(new Moderator());
                        break;
                    case 3:
                        ManagerNavigate.MainFrame.Navigate(new Jury());
                        break;
                    case 4:
                        ManagerNavigate.MainFrame.Navigate(new Member());
                        break;


                }
            }
        }
    }
}
