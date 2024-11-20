using EF_MSSQLgr1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EF_MSSQLgr1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> usersList = null;

        public MainWindow()
        {
          
            InitializeComponent();
            GetUsersFromDb();
            PrepareBinding();
        }

        private void PrepareBinding()
        {
            dgvUsers.ItemsSource = usersList;
        }

        private void GetUsersFromDb()
        {
            using(var context = new AppDBContext())
            {
                usersList = 
                    new ObservableCollection<User>(context.Users.ToList());
            }
        }
    }
}
