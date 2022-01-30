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
    /// Interaction logic for AppointmentLab.xaml
    /// </summary>
    public partial class AppointmentLab : Window
    {
        string email;
        int patientid;
        int doctorid;
        HMDBEntities db = new HMDBEntities();
        public AppointmentLab()
        {
            this.email = "";
            this.patientid = 0;
            this.doctorid = 0;
        }
        public AppointmentLab(string email)
        {
            InitializeComponent();

            this.email = email;

            var docs = from d in db.Doctor1
                       select d.Name;

            this.txtdoctor.ItemsSource = docs.ToList();

            var ptid = from d in db.Patients
                       where d.Email == this.email
                       select new
                       { 
                        patientID = d.Id
                       };
            foreach (var item in ptid)
            {
                this.patientid = item.patientID;
            }

            var lab = from d in db.Labs
                      where d.patient_id == this.patientid
                      select new
                      {
                          DoctorName = d.Doctor.Name,
                          TestType = d.TestType,
                          Appointment = d.AppointmentTime,
                          Remarks = d.DoctorRemarks
                      };
            this.labdata.ItemsSource = lab.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (txtdate.Text == "" || txtdoctor.Text == "" || txttype.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    var docid = from d in db.Doctor1
                                where d.Name == txtdoctor.Text
                                select new
                                {
                                    doctorID = d.Id
                                };
                    foreach (var item in docid)
                    {
                        this.doctorid = item.doctorID;
                    }

                    Lab obj = new Lab();

                    obj.doctor_id = this.doctorid;
                    obj.patient_id = this.patientid;
                    obj.TestType = txttype.Text;
                    obj.AppointmentTime = DateTime.Parse(txtdate.Text);

                    db.Labs.Add(obj);
                    db.SaveChanges();
                    MessageBox.Show("LAb appointment Booked",
                                    "Registration",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information,
                                    MessageBoxResult.OK);

                    var lab = from d in db.Labs
                              where d.patient_id == this.patientid
                              select new
                              {
                                  DoctorName = d.Doctor.Name,
                                  TestType = d.TestType,
                                  Appointment = d.AppointmentTime,
                                  Remarks = d.DoctorRemarks
                              };
                    this.labdata.ItemsSource = lab.ToList();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect Input!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }

        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientsPortal(this.email);
            Page2.Show();
            this.Close();
        }


    }
}
