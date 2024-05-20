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
    /// Логика взаимодействия для AddDetailPage.xaml
    /// </summary>
    public partial class AddDetailPage : Page
    {
        
        public AddDetailPage()
        {
            InitializeComponent();
             CbDetail.ItemsSource = AppData.Context.Detail.ToList();
        }

        private void NewDetailBtn_Click(object sender, RoutedEventArgs e)
        {
            
            var ListD = AppData.Context.Detail.ToList().Where(p => p.DetailName == CbDetail.Text).FirstOrDefault();
            
            var err = "";
            if (CbDetail.SelectedItem == null) err += "Выберите Комплект\n";
            if (!int.TryParse(TbCount.Text, out int amount)) err += "Проверьте правильность заполнения количества";

            if (err == "")
            {
                ListD.Quantity += Convert.ToInt32(TbCount.Text); 
                AppData.Context.SaveChanges();
                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show( "Ошибка");
            }
        }
    }
}
