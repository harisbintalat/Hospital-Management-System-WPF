#pragma checksum "..\..\RegisterDoctor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F7DD51ADB0E1455A93B7380EFCB6DCCA97274EC3924A189E4985AA8C2B0E5308"
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
    /// RegisterDoctor
    /// </summary>
    public partial class RegisterDoctor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelheading;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtage;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtspl;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtqal;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtemail;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtpswd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RegisterDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbio;
        
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
            System.Uri resourceLocater = new System.Uri("/Semester_Project;component/registerdoctor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegisterDoctor.xaml"
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
            
            #line 16 "..\..\RegisterDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_back);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtspl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtqal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtemail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtpswd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.txtbio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 34 "..\..\RegisterDoctor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

