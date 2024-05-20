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

namespace ComService.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddWorPage.xaml
    /// </summary>
    public partial class AddWorPage : Page
    {
        public User _aplu;
        public AddWorPage(User aplu = null)
        {
            InitializeComponent();
            _aplu = aplu;
            if (_aplu != null)
            {
                TbWL.Text = _aplu.Login;
                TbWP.Text = _aplu.Password;
                TbWN.Text = _aplu.UserName;
            }
        }

        private void NewWork_Click(object sender, RoutedEventArgs e)
        {
            var err = "";
           
            if (string.IsNullOrWhiteSpace(TbWN.Text)) err += "Заполните поле Имя работника\n";
            if (string.IsNullOrWhiteSpace(TbWL.Text)) err += "Заполните поле Логин работника\n";
            if (string.IsNullOrWhiteSpace(TbWP.Text)) err += "Заполните поле Пароль работника\n";
            if (err == "")
            {
                if (_aplu == null)
                    _aplu = new User();
                
                _aplu.UserName = TbWN.Text;
                _aplu.Login = TbWL.Text;
                _aplu.Password = TbWP.Text;
                
                _aplu.Roleid = 3;
                AppData.Context.User.Add(_aplu);
                AppData.Context.SaveChanges();
                NavigationService.GoBack();
            }
            else 
            {
                MessageBox.Show(err);
            }
        }
    }
}
