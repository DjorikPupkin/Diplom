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
    /// Логика взаимодействия для AddCompPage.xaml
    /// </summary>
    public partial class AddCompPage : Page
    {
        private Detail _aplu;
        public AddCompPage(Detail aplu = null)
        {
            InitializeComponent();
            _aplu = aplu;
            if (_aplu != null)
            {
               
                TbDN.Text = _aplu.DetailName.ToString();
                
            }
        }

        private void NewDetailBtn_Click(object sender, RoutedEventArgs e)
        {
            var err = "";
            
            if (string.IsNullOrWhiteSpace(TbDN.Text)) err += "Заполните поле описание\n";

            if (err == "")
            {
                if (_aplu == null)
                    _aplu = new Detail();
                _aplu.DetailName = TbDN.Text;
                _aplu.Quantity = 0;
                AppData.Context.Detail.Add(_aplu);
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
