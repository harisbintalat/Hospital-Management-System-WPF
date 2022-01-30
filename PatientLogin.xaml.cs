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
    /// Interaction logic for PatientLogin.xaml
    /// </summary>
   
    public partial class PatientLogin : Window
    {
       // public string name;
        //public string email;
      //  public string password;

        HMDBEntities db = new HMDBEntities();
        public PatientLogin()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtemail.Text == "" || txtpswd.Password == "")
            {
                MessageBox.Show("Feilds cannot be empty!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }
            else if (loginuser(txtemail.Text,txtpswd.Password))
            {
                var Page2 = new PatientsPortal(txtemail.Text);
                Page2.Show();
                this.Close();
            }
          else
            {
                MessageBox.Show("Incorrect Credentials!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }

        }
        private bool loginuser(string email, string password)
        {
            var login = from d in db.Patients
                        where d.Email == txtemail.Text && d.Password == txtpswd.Password
                        select d;

            if(login.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Page2 = new RegisterPatient();
            Page2.Show();
            this.Close();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new HospitalManagement();
            Page2.Show();
            this.Close();
        }
    }
}
