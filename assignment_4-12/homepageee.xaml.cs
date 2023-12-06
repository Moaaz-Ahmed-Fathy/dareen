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
    /// Interaction logic for homepageee.xaml
    /// </summary>
    public partial class homepageee : Page
    {

        examEntities db = new examEntities();  
        public homepageee()
        {
            InitializeComponent();
        }

        private void DeleteUserButton_Click(object sender, RoutedEventArgs e)
        {
            
            string username = poh.Text;

         
            var user = db.user_.FirstOrDefault(u => u.use_name == username);

            if (user != null)
            {
             
                db.user_.Remove(user);
                db.SaveChanges();
            }
            else
            {
             
                MessageBox.Show("User not found.");
            }
        }

    }
}













