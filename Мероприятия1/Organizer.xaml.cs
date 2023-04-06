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
    /// Логика взаимодействия для Organizer.xaml
    /// </summary>
    public partial class Organizer : Page
    {
        public Organizer(string name)
        {
            InitializeComponent();
            txtName.Text = name;
            DateTime date = DateTime.Now;
            if((date.Hour >= 9) && (date.Hour <= 11))
            {
                txtDate.Text = "Доброе утро,";
            }
            if((date.Hour>11)&&(date.Hour <= 18)) {
                txtDate.Text = "Добрый день,";

            }
            if((date.Hour > 18 )&&(date.Hour <= 24)) {
                txtDate.Text = "Добрый вечер,";
            }
            DataContext = Instance.db.Пользователи.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigate.MainFrame.Navigate(new Registration());
        }
    }
}
