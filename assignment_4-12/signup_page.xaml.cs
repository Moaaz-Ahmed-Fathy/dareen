using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for signup_page.xaml
    /// </summary>
    public partial class signup_page : Page
    {
        examEntities db = new examEntities();
        public signup_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool chars_look = false;
            bool numbers_look = false;
            bool sp_look = false;
            Regex regex = new Regex(@"[!@#$%^&*(){}]");
            bool age_look = false;
            bool phone_number_look = false;
            foreach(char c in pass.Text)
            {
                if(( c > 'a' && c <'z') || (c > 'A' && c < 'Z'))
                {
                    chars_look = true;
                }
                if(c>'0' && c<'9')
                {
                    numbers_look = true;
                }
                if(regex.IsMatch(Convert.ToString(c)))
                {
                    sp_look= true;
                }
            }
            if (int.Parse(ne.Text) > 18 && int.Parse(ne.Text) < 60)
            {
                age_look = true;
            }
            else {
                MessageBox.Show("Your age not valied"); 
            } 

            if( pho.Text.Count() == 11)
            {
                phone_number_look= true;
            }
            else
            {
                int co = pho.Text.Count();
                MessageBox.Show(co.ToString() + "   the count of numbers not valied");
            }

            if(chars_look == true && numbers_look == true && sp_look==true && age_look == true && phone_number_look == true) 
            {
                user_ user = new user_();
                user.use_name = userrr.Text;
                user.use_pass = pass.Text;
                user.use_age = ne.Text;
                if(male.IsChecked== true)
                {
                    user.use_gender = "Male";
                }
                else if (female.IsChecked == true)
                {
                    user.use_gender = "female";
                }
                else 
                {
                    user.use_gender = "";
                }
                user_ userre = new user_();
                userre.use_name = userrr.Text;
                userre.use_pass = pass.Text;
                int ph = int.Parse(pho.Text);
                userre.use_phon = pho.Text ;
                userre.use_city = conf.Text;
                db.user_.AddOrUpdate(userre);
                db.SaveChanges();
                MessageBox.Show("signup");


            }
            else
            {
                MessageBox.Show("Please make sure ur password include" + "\n" + "1-char" + "\n" + "2-numbers" + "\n" + "3-speical char" );
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Log_in_page log_In_Page = new Log_in_page();
            this.NavigationService.Navigate(log_In_Page);
        }

        private void female_Checked()
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
