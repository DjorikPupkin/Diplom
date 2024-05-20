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
    /// Логика взаимодействия для WorkerPage.xaml
    /// </summary>
    public partial class WorkerPage : Page
    {
        List<User> ListServ = new List<User>();
        public WorkerPage()
        {
            InitializeComponent();
            ListServ = AppData.Context.User.ToList();


            int gan = 3;
            ListServ = ListServ.Where(p => p.Roleid.ToString().Contains(gan.ToString())).ToList();
            
            DGWor.ItemsSource = ListServ;
        }

        private void RedWorBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddWorBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AddWorPage());
        }
    }
}
