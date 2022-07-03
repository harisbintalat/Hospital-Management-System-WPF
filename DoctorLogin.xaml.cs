using Semester_Project;
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
using System.Windows.Shapes;

namespace SemesterProject
{
    /// <summary>
    /// Interaction logic for DoctorLogin.xaml
    /// </summary>
    public partial class DoctorLogin : Window
    {

        HMDBEntities db = new HMDBEntities();
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Page2 = new RegisterDoctor();
            Page2.Show();
            this.Close();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new HospitalManagement();
            Page2.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(txtemail.Text=="" || txtpswd.Password=="")
            {
                MessageBox.Show("Fields cannot be empty", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else if (loginuser(txtemail.Text, txtpswd.Password))
            {
                var Page2 = new DoctorsPortal(txtemail.Text);
                Page2.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }
        private bool loginuser(string username, string password)
        {
            var login = from d in db.Doctor1
                        where d.Email == txtemail.Text && d.Password == txtpswd.Password
                        select new
                        {
                            email = d.Email,
                            password = d.Password
                        };

            if (login.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
