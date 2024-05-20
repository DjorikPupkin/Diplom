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
    /// Логика взаимодействия для ComplectPage.xaml
    /// </summary>
    public partial class ComplectPage : Page
    {
        public ComplectPage()
        {
            InitializeComponent();
            DGCompl.ItemsSource = AppData.Context.Detail.ToList();
        }

       

        private void AddDetBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AddCompPage());
        }

        private void DelDetBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.Context.Detail.Remove((Detail)DGCompl.SelectedItem);
            AppData.Context.SaveChanges();
            DGCompl.ItemsSource = AppData.Context.Detail.ToList();
        }
    }
}
