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
    /// Interaction logic for DoctorsDetail.xaml
    /// </summary>
 
    public partial class DoctorsDetail : Window
    {
        string email;

        HMDBEntities db = new HMDBEntities();
        public DoctorsDetail()
        {
            this.email = "";
        }
        public DoctorsDetail(string email)
        {
            InitializeComponent();
            this.email = email;

            var docs = from d in db.Doctor1
                       select new
                       {
                           DoctorName = d.Name,
                           DoctorSpec = d.Specialization
                       };
            listboxnames.ItemsSource = docs.ToList();
        }

        private void btnfilter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textboxfilter.Text == "")
                {
                    MessageBox.Show("Please enter name!", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {

                    var docs = from d in db.Doctor1
                               where d.Name == textboxfilter.Text
                               select new
                               {
                                   DoctorName = "Name: " + d.Name,
                                   DoctorAge = "Age: " + d.Age,
                                   DoctorEmail = "Email:" + d.Email,
                                   DoctorQual = "Qualification: " + d.Qualification,
                                   DoctorSpec = "Specialization: " + d.Specialization,
                                   DoctorBio = "Biography: " + d.Biography,

                               };
                    if(docs.Count()>0)
                    {
                        listboxresult.ItemsSource = docs.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Doctor not found!", "Error", MessageBoxButton.OK,
                      MessageBoxImage.Error, MessageBoxResult.OK);
                        listboxresult.ItemsSource = docs.ToList();
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Unknown Error!", "Error", MessageBoxButton.OK,
                       MessageBoxImage.Error, MessageBoxResult.OK);
            }
 
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientsPortal(email);
            Page2.Show();
            this.Close();
        }

        private void listboxnames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textboxfilter.Text = "";
            var docs = from d in db.Doctor1
                       where d.Name == txtdoc.Text
                       select new
                       {
                           DoctorName = "Name: " + d.Name,
                           DoctorAge = "Age: " + d.Age,
                           DoctorEmail = "Email:" + d.Email,
                           DoctorQual = "Qualification: " + d.Qualification,
                           DoctorSpec = "Specialization: " + d.Specialization,
                           DoctorBio = "Biography: " + d.Biography,

                       };
            listboxresult.ItemsSource = docs.ToList();
        }
    }
}
