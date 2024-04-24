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

namespace Проверочная_работа_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientPage.xaml
    /// </summary>
    public partial class PatientPage : Page
    {
        public PatientPage()
        {
            InitializeComponent();
            

            List<String> x1 = new List<string>();
            var c = MainWindow.db.country.ToList();
            x1.Add("Все страны");
            foreach (var item in c)
            {
                x1.Add(item.country_name);
            }
            cbCountry.ItemsSource = x1;
            cbCountry.SelectedItem = x1[0];

            List<String> x2 = new List<string>();
            var i = MainWindow.db.incurance.ToList();
            x2.Add("Все страховые компании");
            foreach (var item in i)
            {
                x2.Add(item.insurance_name);
            }
            cbInsurance.ItemsSource = x2;
            cbInsurance.SelectedItem = x2[0];

            List<String> x3 = new List<string>();
            var st = MainWindow.db.social_type.ToList();
            x3.Add("Все типы мед. полиса");
            foreach (var item in st)
            {
                x3.Add(item.social);
            }
            cbSocialType.ItemsSource = x3;
            cbSocialType.SelectedItem = x3[0];
            
            lw1.ItemsSource = MainWindow.db.patients.ToList();
        }
        
        private void cbInsurance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var z = MainWindow.db.patients.ToList();
            if ((string)cbInsurance.SelectedItem == "Все страховые компании") lw1.ItemsSource = z;
            else
            {
                z = z.Where(n => n.incurance.patients.Any(t => t.incurance.insurance_name == cbInsurance.Text)).ToList();
            }
            lw1.ItemsSource = z;
        }

        private void cbSocialType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var z = MainWindow.db.patients.ToList();

            if ((string)cbInsurance.SelectedItem == "Все типы мед. полиса") lw1.ItemsSource = z;
            else
            {
                z = z.Where(n => n.social_type1.patients.Any(t => t.social_type1.social == cbSocialType.Text)).ToList();
            }
            lw1.ItemsSource = z;
        }

        private void cbCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var z = MainWindow.db.patients.ToList();

            if ((string)cbInsurance.SelectedItem == "Все страны") lw1.ItemsSource = z;
            else
            {
                z = z.Where(n => n.country1.patients.Any(t => t.country1.country_name == cbCountry.Text)).ToList();
            }
            lw1.ItemsSource = z;
        }

        private void loginSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.db.patients.ToList();
            string seachText = tbLogin.Text;
            if (!string.IsNullOrWhiteSpace(seachText))
            {
                x = x.Where(p => p.login.ToLower().StartsWith(seachText.ToLower())).ToList();
            }
            lw1.ItemsSource = x;
        }

        private void FIOSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var x = MainWindow.db.patients.ToList();
            string seachText = tbFIO.Text;
            if (!string.IsNullOrWhiteSpace(seachText))
            {
                x = x.Where(p => p.full_name.ToLower().StartsWith(seachText.ToLower())).ToList();
            }
            lw1.ItemsSource = x;
        }
    }
}
