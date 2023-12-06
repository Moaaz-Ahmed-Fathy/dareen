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
    /// Interaction logic for forget_pass_page.xaml
    /// </summary>
    public partial class forget_pass_page : Page
    {
        examEntities db = new examEntities();
        public forget_pass_page()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool chars_look = false;
            bool numbers_look = false;
            bool sp_look = false;
            Regex regex = new Regex(@"[!@#$%^&*(){}]");

            if (nnew.Text == conf.Text)
            {
                foreach (char c in nnew.Text)
                {
                    if ((c > 'a' && c < 'z') || (c > 'A' && c < 'Z'))
                    {
                        chars_look = true;
                    }
                    if (c > '0' && c < '9')
                    {
                        numbers_look = true;
                    }
                    if (regex.IsMatch(Convert.ToString(c)))
                    {
                        sp_look = true;
                    }
                }
                if (chars_look == true && numbers_look == true && sp_look == true)
                {
                    user_ nuser = db.user_.FirstOrDefault(x => x.use_phon == pho.Text);
                    if (nuser != null)
                    {
                        nuser.use_pass = conf.Text;
                        db.user_.AddOrUpdate(nuser);
                        db.SaveChanges();
                        MessageBox.Show("Password updated successfully!");
                        Log_in_page log_In_Page = new Log_in_page();
                        this.NavigationService.Navigate(log_In_Page);
                    }
                    else
                    {
                        MessageBox.Show("Not user!");
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure ur password include" + "\n" + "1-char" + "\n" + "2-numbers" + "\n" + "3-speical char");
                }
            }
            else
            {
                MessageBox.Show("Passwords not match!");
            }
        }
    }
}
