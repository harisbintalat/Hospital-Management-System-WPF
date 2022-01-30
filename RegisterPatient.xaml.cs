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
    /// Interaction logic for RegisterPatient.xaml
    /// </summary>
    public partial class RegisterPatient : Window
    {
        // HsptlDBEntities db = new HsptlDBEntities();
        HMDBEntities db = new HMDBEntities();

        public RegisterPatient()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool checkEmail=false;
            try
            {
                if (txtpswd.Password == "" || txtname.Text == "" || txtage.Text == "" || txtdob.Text == "" || txtemail.Text == "" || txtadrs.Text == "")
                {
                    MessageBox.Show("Feilds cannot be empty!", "Error", MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    var check = from d in db.Patients
                                select d;

                    foreach (var item in check)
                    {
                        if(item.Email==txtemail.Text)
                        {
                            checkEmail = true;
                        }
                    }

                    if(checkEmail==true)
                    {
                        MessageBox.Show("Email already Registered",
                        "Registration Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error,
                        MessageBoxResult.OK);
                    }
                    else
                    {
                        Patient obj = new Patient();

                        obj.Name = txtname.Text;
                        obj.Age = int.Parse(txtage.Text);
                        obj.DOB = DateTime.Parse(txtdob.Text);
                        obj.BloodGroup = txtbg.Text;
                        obj.Email = txtemail.Text;
                        obj.Password = txtpswd.Password;
                        obj.Address = txtadrs.Text;
                        db.Patients.Add(obj);
                        db.SaveChanges();

                        MessageBox.Show("Patient Registered, Login to Continue",
                       "Registration",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information,
                         MessageBoxResult.OK);

                        var Page2 = new PatientLogin();
                        Page2.Show();
                        this.Close();
                    }
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
            var Page2 = new PatientLogin();
            Page2.Show();
            this.Close();
        }
    }
}
