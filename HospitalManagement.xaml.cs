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
    /// Interaction logic for HospitalManagement.xaml
    /// </summary>
    public partial class HospitalManagement : Window
    {
        public HospitalManagement()
        {
            InitializeComponent();
        }

        private void Button_doctor(object sender, RoutedEventArgs e)
        {
            var Page2 = new DoctorLogin();
            Page2.Show();
            this.Close();
        }

        private void Button_patient(object sender, RoutedEventArgs e)
        {
            var Page2 = new PatientLogin();
            Page2.Show();
            this.Close();
        }
    }
}
