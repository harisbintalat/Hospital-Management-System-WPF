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
    /// Interaction logic for PatientsPortal.xaml
    /// </summary>

    public partial class PatientsPortal : Window 
    {
        public string email;

        HMDBEntities db = new HMDBEntities();
        
        public PatientsPortal()
        {
            InitializeComponent();
            this.email = "";
        }
        public PatientsPortal(string email)
        {
            InitializeComponent();
            Patient obj1 = new Patient();
            this.email = email;

            var profile = from d in db.Patients
                          where d.Email == this.email
                          select new
                          { 
                            ProfileName = "Name: "+d.Name,
                            ProfileAge = "Age: "+d.Age,
                            ProfileDOB = "DOB: "+d.DOB,
                            ProfileEmail ="Email: "+ d.Email,
                            ProfileBg = "Blood Group: "+d.BloodGroup,
                            ProfileAddress ="Address: "+ d.Address
                          };
            listboxprofile.ItemsSource = profile.ToList();

        }

        private void Button_Appointment(object sender, RoutedEventArgs e)
        {
            var Page2 = new ManageAppointments(email); 
            Page2.Show();
            this.Close();
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            var Page2 = new UpdatePatient(email);
            Page2.Show();
            this.Close();
        }

        private void Button_Doctor(object sender, RoutedEventArgs e)
        {
            var Page2 = new DoctorsDetail(email);
            Page2.Show();
            this.Close();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientLogin();
            Page2.Show();
            this.Close();
        }

        private void Button_labs(object sender, RoutedEventArgs e)
        {
            var Page2 = new AppointmentLab(this.email);
            Page2.Show();
            this.Close();
        }
    }
}
