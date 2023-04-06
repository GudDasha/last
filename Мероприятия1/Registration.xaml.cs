using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public static Пользователи user = new Пользователи();
        public Registration()
        {
            InitializeComponent();
            Random random = new Random();
            int r = random.Next(1000,9999);
            txtNumber.Text = Convert.ToString(r);
            txtGender.Items.Add("женский");
            txtRole.ItemsSource = Instance.db.Роли.ToList();
            txtEvent.ItemsSource = Instance.db.Пользователи.ToList();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            user.уникальный_код = txtNumber.Text;
            user.ФИО = txtName.Text;
          //  user.пол = txtGender.SelectedItem.ToString();
            var role = txtRole.SelectedItem as Роли;
            user.код_роли = role.Код_роли;
            user.почта = txtEmail.Text;
            user.телефон = txtPhone.Text;
            user.направление = txtDirection.Text;
            if(checkEvent.IsChecked == true)
            {
                lbEvent.IsEnabled = true;
                txtEvent.IsEnabled = true;
                var user = txtEvent.SelectedItem as Пользователи;
                user.мероприятие = user.мероприятие;
            }
            if (pbPassword.Password == pbPassword2.Password)
            {
                user.пароль = pbPassword.Password;
            }
            else
            {
                MessageBox.Show("Плохо");
            }
            Instance.db.Пользователи.Add(user);
            Instance.db.SaveChanges();
            MessageBox.Show("Данные сохранены");
            ManagerNavigate.MainFrame.Navigate(new Organizer(null));
        }
    }
}
