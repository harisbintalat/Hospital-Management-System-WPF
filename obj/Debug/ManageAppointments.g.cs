#pragma checksum "..\..\ManageAppointments.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06AD90C23D595FA9BF101EE53A5A2C81D77AD7316A3BA2D13C6B4C8CC182A83D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SemesterProject;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SemesterProject {
    
    
    /// <summary>
    /// ManageAppointments
    /// </summary>
    public partial class ManageAppointments : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelheading;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbldate;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbldoctor;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtdoctor;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnapt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtdate;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbldisease;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdisease;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbldetails;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdetails;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listapointments;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ManageAppointments.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Semester_Project;component/manageappointments.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageAppointments.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelheading = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 15 "..\..\ManageAppointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_back);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbldate = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lbldoctor = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtdoctor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnapt = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\ManageAppointments.xaml"
            this.btnapt.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtdate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.lbldisease = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txtdisease = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.lbldetails = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.txtdetails = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.listapointments = ((System.Windows.Controls.ListBox)(target));
            
            #line 30 "..\..\ManageAppointments.xaml"
            this.listapointments.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listapointments_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 14:
            this.txtdel = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 38 "..\..\ManageAppointments.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Buttondel_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

