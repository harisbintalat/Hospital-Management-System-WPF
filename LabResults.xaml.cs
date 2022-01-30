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
    /// Interaction logic for LabResults.xaml
    /// </summary>
    public partial class LabResults : Window
    {
        string email;
        int doctorid;
        int aptid;

        HMDBEntities db = new HMDBEntities();
        public LabResults()
        {
            this.email = "";
            this.doctorid = 0;
            this.aptid = 0;
        }
        public LabResults(string email)
        {
            InitializeComponent();

            this.email = email;

            var docid = from d in db.Doctor1
                        where d.Email == this.email
                        select new
                        {
                            Docid = d.Id
                        };
            foreach (var item in docid)
            {
                this.doctorid = item.Docid;
            }

            var labs = from d in db.Labs
                       where d.doctor_id == doctorid
                       select new
                       {
                      PtID = d.Id,                        
                      PtName =d.Patient.Name,
                      PtAge ="Age: " +  d.Patient.Age,
                      PtBg = "Blood Group: "+ d.Patient.BloodGroup,
                      PtTt = "Test: "+ d.TestType,
                      PtTime = "Time:"+ d.AppointmentTime,
                      PtRm = "Doctor Remarks: "+ d.DoctorRemarks
                       };
            this.labdata.ItemsSource = labs.ToList();


        }


        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new DoctorsPortal(this.email);
            Page2.Show();
            this.Close();
        }
        private void labdata_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                this.aptid = int.Parse(txtapt.Text);
            }
            catch (Exception)
            {
                this.aptid = 0;

            }
        }
        private void Buttondetails_Click(object sender, RoutedEventArgs e)
        {
            var remarks = from d in db.Labs
                          where d.Id == this.aptid
                          select d;
            foreach (var item in remarks)
            {
                item.DoctorRemarks = txtremarks.Text;
            }
            db.SaveChanges();
            var labs = from d in db.Labs
                       where d.doctor_id == doctorid
                       select new
                       {
                           PtID = d.Id,
                           PtName = d.Patient.Name,
                           PtAge = "Age: " + d.Patient.Age,
                           PtBg = "Blood Group: " + d.Patient.BloodGroup,
                           PtTt = "Test: " + d.TestType,
                           PtTime = "Time:" + d.AppointmentTime,
                           PtRm = "Doctor Remarks: " + d.DoctorRemarks
                       };
            this.labdata.ItemsSource = labs.ToList();

        }


    }
}
