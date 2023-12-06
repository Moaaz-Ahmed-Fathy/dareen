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
    /// Interaction logic for searsh.xaml
    /// </summary>
    public partial class searsh : Page
    {
        examEntities db = new examEntities();

        public searsh()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchText = searchTextBox.Text; 

            var users = db.user_.Where(u => u.use_name.Contains(searchText) || u.use_phon.ToString() == searchText).ToList();
           // var admins = db.adminnn.Where(a => a.add_namee.Contains(searchText)).ToList();

           // dataGrid.ItemsSource = users.Concat(admins).ToList();
        }

    }
}
