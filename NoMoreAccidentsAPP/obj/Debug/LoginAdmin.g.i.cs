﻿#pragma checksum "..\..\LoginAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7AAEE193210B675B90870BAE2C5FB218C3C441ECD47C6148DFA07B1B2BAB9492"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using NoMoreAccidentsAPP;
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


namespace NoMoreAccidentsAPP {
    
    
    /// <summary>
    /// LoginAdmin
    /// </summary>
    public partial class LoginAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizarAdministrador;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrarAdministrador;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuarioAdministrador;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPasswordAdministrador;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\LoginAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoginAdministrador;
        
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
            System.Uri resourceLocater = new System.Uri("/NoMoreAccidentsAPP;component/loginadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginAdmin.xaml"
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
            
            #line 14 "..\..\LoginAdmin.xaml"
            ((NoMoreAccidentsAPP.LoginAdmin)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnMinimizarAdministrador = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\LoginAdmin.xaml"
            this.btnMinimizarAdministrador.Click += new System.Windows.RoutedEventHandler(this.btnMinimizarAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCerrarAdministrador = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\LoginAdmin.xaml"
            this.btnCerrarAdministrador.Click += new System.Windows.RoutedEventHandler(this.btnCerrarAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtUsuarioAdministrador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtPasswordAdministrador = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.btnLoginAdministrador = ((System.Windows.Controls.Button)(target));
            
            #line 219 "..\..\LoginAdmin.xaml"
            this.btnLoginAdministrador.Click += new System.Windows.RoutedEventHandler(this.btnLoginxAdmin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
