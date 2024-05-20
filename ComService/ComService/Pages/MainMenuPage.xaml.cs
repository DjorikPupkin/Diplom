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
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }

        private void AplBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AplPageAllA());
        }

        private void ComBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new ComplectPage());
        }

        private void WorkBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new WorkerPage());
        }

        private void AplBtnD_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AplPageA());
        }

       

        private void DetBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AddDetailPage());

        }

        private void DetBtnP_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new DetPage());
        }
    }
}
