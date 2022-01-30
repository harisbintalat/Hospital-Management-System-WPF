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
    /// Interaction logic for UpdatePatient.xaml
    /// </summary>
    public partial class UpdatePatient : Window
    {
        string email;

        HMDBEntities db = new HMDBEntities();
        public UpdatePatient()
        {
            this.email = "";
        }
        public UpdatePatient(string email)
        {
            InitializeComponent();
            this.email = email;

            var qry = from d in db.Patients
                      where this.email == d.Email
                      select d;

            foreach (var item in qry)
            {
                lblname.Text = item.Name;
                lblage.Text = item.Age.ToString();
                lbldob.Text = item.DOB.ToString();
                lblbg.Text = item.BloodGroup;
                lblemail.Text = item.Email;
                lbladrs.Text = item.Address;
            }

         /*   if (this.griddoctors.SelectedIndex >= 0)
            {
                if (this.griddoctors.SelectedItems.Count >= 0)
                {
                    if (this.griddoctors.SelectedItems[0].GetType() == typeof(Doctor))
                    {
                        Doctor d = (Doctor)this.griddoctors.SelectedItems[0];
                        this.txtnameup.Text = d.Name;
                        this.txtspecup.Text = d.Specialization;
                        this.txtdesig_Copy.Text = d.Designation;
                        this.updateddoctor = d.Id;
                    }
                }
            } */
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientsPortal(email);
            Page2.Show();
            this.Close();
        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lblpswd.Password == "" || lblname.Text=="" || lblage.Text=="" || lbldob.Text=="" || lblbg.Text=="" || lbladrs.Text=="")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    var qry = from d in db.Patients
                              where this.email == d.Email
                              select d;

                    foreach (var item in qry)
                    {

                        item.Name = lblname.Text;
                        item.Age = int.Parse(lblage.Text);
                        item.DOB = DateTime.Parse(lbldob.Text);
                        item.BloodGroup = lblbg.Text;
                        item.Email = lblemail.Text;
                        item.Password = lblpswd.Password;
                        item.Address = lbladrs.Text;

                    }
                    db.SaveChanges();

                    MessageBox.Show("Record Updated",
                       "Registration",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information,
                       MessageBoxResult.OK);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect Input!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }
    }
}
