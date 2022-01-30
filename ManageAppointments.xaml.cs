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
    /// Interaction logic for ManageAppointments.xaml
    /// </summary>
    public partial class ManageAppointments : Window
    {
        string email;
        int delete;

        HMDBEntities db = new HMDBEntities();
        public ManageAppointments()
        {
            this.email = "";
        }
        public ManageAppointments(string email)
        {
            InitializeComponent();

            Patient obj1 = new Patient();
          
            this.email = email;

            var docs = from d in db.Doctor1
                       select d.Name; 
                       
            txtdoctor.ItemsSource = docs.ToList();


            var manage = from d in db.Patients
                         where d.Email == this.email
                         select d;
            foreach (var item in manage)
            {
                obj1.Id = item.Id;
            }

            var apts = from d in db.Appointments
                       where d.patient_id == obj1.Id
                       select new
                       { 
                        aId = d.Id,
                        aName ="Doctor Name: "+ d.DoctorName,
                        aDate ="Appointment Date: "+ d.appointment_date,
                        aDetails ="Details: " +d.appointment_details
                       };
            listapointments.ItemsSource = apts.ToList();
        }

        private void Button_back(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientsPortal(email);
            Page2.Show();
            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string docname;
            bool CheckDoc = false;
            int ptID=0;
            try
            {
                if(txtdate.Text=="" || txtdoctor.Text=="" || txtdisease.Text=="" || txtdisease.Text=="")
                {
                    MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButton.OK,
                   MessageBoxImage.Error, MessageBoxResult.OK);
                }
                else
                {
                    var ptnet = from d in db.Patients
                                where d.Email == this.email
                                select d;
                    foreach (var item in ptnet)
                    {
                        ptID = item.Id;
                    }
                    var check = from d in db.Appointments
                                where ptID == d.patient_id
                                select d;
                    foreach (var item in check)
                    {
                        if (item.DoctorName == txtdoctor.Text)
                        {
                            CheckDoc = true;
                        }
                    }
                    if (check.Count() >= 3)
                    {
                        MessageBox.Show("Maximum of 3 appointments are allowed!",
                                   "Error",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Error,
                                   MessageBoxResult.OK);
                    }
                    else
                    {
                        if (CheckDoc == true)
                        {
                            MessageBox.Show("Appointment with " + txtdoctor.Text + " Already booked!",
                                   "Error",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Error,
                                   MessageBoxResult.OK);
                        }

                        else
                        {
                            Appointment obj = new Appointment();
                            PatientDisease obj3 = new PatientDisease();

                            obj.appointment_date = txtdate.SelectedDate;
                            obj.DoctorName = txtdoctor.Text;
                            obj.appointment_details = txtdetails.Text;
                            obj3.Date = txtdate.SelectedDate;

                            docname = txtdoctor.Text;
                            var docid = from d in db.Doctor1
                                        where d.Name == docname
                                        select d;
                            foreach (var item in docid)
                            {
                                obj.doctor_id = item.Id;
                            }

                            var manage = from d in db.Patients
                                         where d.Email == this.email
                                         select d;

                            foreach (var item in manage)
                            {

                                obj3.Patient_id = item.Id;
                                obj.patient_id = item.Id;

                            }

                            obj3.Disease = txtdisease.Text;

                            db.Appointments.Add(obj);
                            db.PatientDiseases.Add(obj3);
                            db.SaveChanges();

                            MessageBox.Show("Appointment Booked",
                            "Registration",
                             MessageBoxButton.OK,
                             MessageBoxImage.Information,
                            MessageBoxResult.OK);


                            var apts = from d in db.Appointments
                                       where d.patient_id == obj3.Patient_id
                                       select new
                                       {
                                           aId = d.Id,
                                           aName = "Doctor Name: " + d.DoctorName,
                                           aDate = "Appointment Date: " + d.appointment_date,
                                           aDetails = "Details: " + d.appointment_details
                                       };
                            listapointments.ItemsSource = apts.ToList();
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Incorrect Input!", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error, MessageBoxResult.OK);
            }
            
        }
        private void listapointments_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            try
            {
                this.delete = int.Parse(txtdel.Text);
            }
            catch(Exception)
            {
                this.delete = 0;

            }
            
        }
        private void Buttondel_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult msgbox = MessageBox.Show("Do you want to Cancel the appointment?",
                "Delete Row",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning,
                MessageBoxResult.No);
            if (msgbox == MessageBoxResult.Yes)
            {

                var r = from d in db.Appointments
                        where d.Id == this.delete
                        select d;
                Appointment obj = r.SingleOrDefault();

                if (obj != null)
                {
                    db.Appointments.Remove(obj);
                    db.SaveChanges();
                }


                Patient obj1 = new Patient();
                var manage = from d in db.Patients
                             where d.Email == this.email
                             select d;
                foreach (var item in manage)
                {
                    obj1.Id = item.Id;
                }

                var apts = from d in db.Appointments
                           where d.patient_id == obj1.Id
                           select new
                           {
                               aId = d.Id,
                               aName = d.DoctorName,
                               aDate = d.appointment_date,
                               aDetails = d.appointment_details
                           };
                listapointments.ItemsSource = apts.ToList();
            }

        }


    }
}
