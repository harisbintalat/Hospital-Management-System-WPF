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
    /// Interaction logic for DoctorsPortal.xaml
    /// </summary>
    public partial class DoctorsPortal : Window
    {
        string email;
        int doctorid;
        int aptcomplete;
        string selectedpatient;
        HMDBEntities db = new HMDBEntities();
        public DoctorsPortal()
        {
            this.email = "";
            this.doctorid = 0;
            this.aptcomplete = 0;
            this.selectedpatient = "";
        }
        public DoctorsPortal(string email)
        {
            InitializeComponent();
            this.email = email;

            var docid = from d in db.Doctor1
                        where d.Email == this.email
                        select d;

            foreach (var item in docid)
            {
                this.doctorid = item.Id;
            }

            var apts = from a in db.Appointments
                       where a.doctor_id == this.doctorid
                       select new
                       {
                           AptID =a.Id,
                           PatinentName =a.Patient.Name,
                           PatientAge ="Age: "+ a.Patient.Age,
                           AppointmentTime ="Appointment Time: "+ a.appointment_date,
                           Detail ="Details:"+ a.appointment_details,
                           a.Patient.Email
                       };

            listboxapt.ItemsSource = apts.ToList();

            var docs = from d in db.Doctor1
                       where d.Email == this.email
                       select new
                       {
                           DoctorName ="Name: "+ d.Name,
                           DoctorAge = "Age: "+ d.Age,
                           DoctorEmail ="Email: "+ d.Email,
                           DoctorQual ="Qualification: "+ d.Qualification,
                           DoctorSpel ="Specialization: "+ d.Specialization,
                           DoctorBio = "Biography: "+d.Biography
                       };
            listboxprofile.ItemsSource = docs.ToList();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new DoctorLogin();
            Page2.Show();
            this.Close();
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            var Page2 = new UpdateDoctor(email);
            Page2.Show();
            this.Close();
        }

        private void listboxapt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                this.aptcomplete = int.Parse(aptcom.Text);
                this.selectedpatient = ptname.Text;

            }
            catch (Exception)
            {
                this.aptcomplete = 0;

            }
        }

        private void Buttondetails_Click(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientInfo(this.selectedpatient, this.email);
            Page2.Show();
            this.Close();
        }

        private void Buttonaction_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msgbox = MessageBox.Show("Do you want to Remove the appointment?",
                                        "Action",
                                        MessageBoxButton.YesNo,
                                        MessageBoxImage.Warning,
                                        MessageBoxResult.No);
            if (msgbox == MessageBoxResult.Yes)
            {

                var r = from d in db.Appointments
                        where d.Id == this.aptcomplete
                        select d;
                Appointment obj = r.SingleOrDefault();

                if (obj != null)
                {
                    db.Appointments.Remove(obj);
                    db.SaveChanges();
                }


                var docid = from d in db.Doctor1
                            where d.Email == this.email
                            select d;

                foreach (var item in docid)
                {
                    this.doctorid = item.Id;
                }

                var apts = from a in db.Appointments
                           where a.doctor_id == this.doctorid
                           select new
                           {
                               AptID = a.Id,
                               PatinentName =a.Patient.Name,
                               PatientAge = "Age: " + a.Patient.Age,
                               AppointmentTime = "Appointment Time: " + a.appointment_date,
                               Detail = "Details:" + a.appointment_details
                           };
                listboxapt.ItemsSource = apts.ToList();
            }
        }

        private void Button_labs(object sender, RoutedEventArgs e)
        {
            var Page2 = new LabResults(this.email);
            Page2.Show();
            this.Close();
        }
    }
}
