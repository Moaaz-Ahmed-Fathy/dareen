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

namespace assignment_4_12
{
    /// <summary>
    /// Interaction logic for Log_in_page.xaml
    /// </summary>
    public partial class Log_in_page : Page
    {
        examEntities db = new examEntities();
        public Log_in_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            signup_page signup_Page = new signup_page();
            this.NavigationService.Navigate(signup_Page);
           //user_ user1 = new user_();
           // bool look = false;
           // foreach(user_ users in db.user_)
           // {
           //     if (users.use_name == user.Text && users.use_pass == pass.Text)
           //     {
           //         look = true;
           //         user1= users;
           //     }
           // }
           // if(look)
           // {
           //     profile_page profile_Page = new profile_page(user1);
           //     this.NavigationService.Navigate(profile_Page);
           // }
           // else
           // {
           //     MessageBox.Show("Your not user!");
           // }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            forget_pass_page forget_Pass_Page = new forget_pass_page();
            this.NavigationService.Navigate(forget_Pass_Page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            signup_page signup_Page = new signup_page();
            this.NavigationService.Navigate(signup_Page);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            homepageee homepageee = new homepageee();
            this.NavigationService.Navigate(homepageee);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            searsh searsh = new searsh();
            this.NavigationService.Navigate(searsh);
        }
    }
}
