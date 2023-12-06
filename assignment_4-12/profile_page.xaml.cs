using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace assignment_4_12
{
    /// <summary>
    /// Interaction logic for profile_page.xaml
    /// </summary>
    public partial class profile_page : Page
    {
        public profile_page(user_ userr)
        {
            InitializeComponent();
            welcomeLabel.Content = "Welcome" + userr.use_name;
            username.IsEnabled = false; password.IsEnabled = false; age.IsEnabled = false; gender.IsEnabled = false; pho.IsEnabled = false; city.IsEnabled = false;
            username.Text = userr.use_name.ToString();
            for (int i = 0; i < userr.use_pass.Count(); i++)
            {
                password.Text += "*";
            }
            age.Text = userr.use_age.ToString();
            gender.Text = userr.use_gender.ToString();
            pho.Text = userr.use_phon.ToString();
            city.Text = userr.use_city.ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Log_in_page log_In_Page = new Log_in_page();
            this.NavigationService.Navigate(log_In_Page);
        }
    }
}
