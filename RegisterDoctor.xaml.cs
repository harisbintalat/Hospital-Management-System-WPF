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
    /// Interaction logic for RegisterDoctor.xaml
    /// </summary>
    public partial class RegisterDoctor : Window
    {
          
        
        HMDBEntities db = new HMDBEntities();
        public RegisterDoctor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool checkEmail = false;
           try
            {
                if (txtname.Text == "" || txtage.Text == "" || txtspl.Text == "" || txtqal.Text == "" || txtemail.Text == "" || txtpswd.Password == "" || txtbio.Text == "")
                {
                    MessageBox.Show("Feilds cannot be empty!", "Error", MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    var check = from d in db.Doctor1
                                select d;

                    foreach (var item in check)
                    {
                        if (item.Email == txtemail.Text)
                        {
                            checkEmail = true;
                        }
                    }

                    if (checkEmail == true)
                    {
                        MessageBox.Show("Email already Registered",
                        "Registration Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error,
                        MessageBoxResult.OK);
                    }
                    else
                    {
                        Doctor1 obj = new Doctor1();

                        obj.Name = txtname.Text;
                        obj.Age = int.Parse(txtage.Text);
                        obj.Specialization = txtspl.Text;
                        obj.Qualification = txtqal.Text;
                        obj.Email = txtemail.Text;
                        obj.Password = txtpswd.Password;
                        obj.Biography = txtbio.Text;

                        db.Doctor1.Add(obj);
                        db.SaveChanges();

                        MessageBox.Show("Doctor Registered, Login to Continue",
                         "Registration",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information,
                         MessageBoxResult.OK);

                        var Page2 = new DoctorLogin();
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
            var Page2 = new DoctorLogin();
            Page2.Show();
            this.Close();
        }
    }
}
