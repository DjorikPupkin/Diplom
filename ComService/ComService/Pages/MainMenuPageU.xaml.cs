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
    /// Логика взаимодействия для MainMenuPageU.xaml
    /// </summary>
    public partial class MainMenuPageU : Page
    {
        public MainMenuPageU()
        {
            InitializeComponent();
        }

        private void NewAplBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AddAplPage());
        }

        private void AplBtn_Click(object sender, RoutedEventArgs e)
        {
            AppData.MainFrame.Navigate(new AplPage());
        }
    }
}
