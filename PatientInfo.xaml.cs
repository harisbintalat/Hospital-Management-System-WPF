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
    /// Interaction logic for PatientInfo.xaml
    /// </summary>
    public partial class PatientInfo : Window
    {
        HMDBEntities db = new HMDBEntities();
        string ptname;
        string email;
        int ptid;
        public PatientInfo()
        {
            this.ptname = "";
            this.email = "";
            this.ptid = 0;
        }
        public PatientInfo(string ptname, string email)
        {
            InitializeComponent();

            this.ptname = ptname;
            this.email = email;
           // MessageBox.Show("x"+this.ptname+"x");
            var ptsdetail = from d in db.Patients
                            where d.Name == this.ptname
                            select new
                            { 
                                d.Id,
                                Name ="Name: "+ d.Name,
                                Age = "Age: "+ d.Age,
                                BloodGroup = "Blood Group: "+ d.BloodGroup,
                                Email = "Email: "+ d.Email,
                                Address ="Address: "+ d.Address,
                            };

            foreach (var item in ptsdetail)
            {
               this.ptid = item.Id;
            }
            this.listboxdetails.ItemsSource = ptsdetail.ToList();

            //MessageBox.Show(this.ptid.ToString());
            var history = from d in db.PatientDiseases
                          where d.Patient_id == this.ptid
                          select new
                          {
                              disease = d.Disease,
                              date ="Apointment Date: "+ d.Date
                          };
            this.listboxapt.ItemsSource = history.ToList();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new DoctorsPortal(this.email);
            Page2.Show();
            this.Close();
        }
    }
}
