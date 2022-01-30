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
    /// Interaction logic for UpdateDoctor.xaml
    /// </summary>
    public partial class UpdateDoctor : Window
    {
        string email;

        HMDBEntities db = new HMDBEntities();
        public UpdateDoctor()
        {
            this.email = "";
        }
        public UpdateDoctor(string email)
        {
            InitializeComponent();

            this.email = email;

            var qry = from d in db.Doctor1
                      where this.email == d.Email
                      select d;

            foreach (var item in qry)
            {
                txtname.Text = item.Name;
                txtage.Text = item.Age.ToString();
                txtspl.Text = item.Specialization;
                txtqal.Text = item.Qualification;
                txtemail.Text = item.Email;
                txtbio.Text = item.Biography;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(txtname.Text == "" || txtage.Text == "" || txtspl.Text == "" || txtqal.Text == "" || txtemail.Text == "" || txtpswd.Password == "" || txtbio.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    var qry = from d in db.Doctor1
                              where this.email == d.Email
                              select d;

                    foreach (var item in qry)
                    {

                        item.Name = txtname.Text;
                        item.Age = int.Parse(txtage.Text);
                        item.Specialization = txtspl.Text;
                        item.Qualification = txtqal.Text;
                        item.Email = txtemail.Text;
                        item.Password = txtpswd.Password;
                        item.Biography = txtbio.Text;

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

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new DoctorsPortal(email);
            Page2.Show();
            this.Close();
        }
    }
}
