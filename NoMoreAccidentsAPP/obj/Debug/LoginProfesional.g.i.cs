﻿#pragma checksum "..\..\LoginProfesional.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36CADE89B4A3C9A00F2F0C9DB440FE0D0319BBEA106377080870F905DE47C189"
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
    /// LoginProfesional
    /// </summary>
    public partial class LoginProfesional : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\LoginProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizarProfesional;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\LoginProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrarProfesional;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\LoginProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuarioProfesional;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\LoginProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPasswordProfesional;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\LoginProfesional.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoginProfesional;
        
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
            System.Uri resourceLocater = new System.Uri("/NoMoreAccidentsAPP;component/loginprofesional.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginProfesional.xaml"
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
            this.btnMinimizarProfesional = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\LoginProfesional.xaml"
            this.btnMinimizarProfesional.Click += new System.Windows.RoutedEventHandler(this.btnMinimizarProfesional_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCerrarProfesional = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\LoginProfesional.xaml"
            this.btnCerrarProfesional.Click += new System.Windows.RoutedEventHandler(this.btnCerrarProfesional_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUsuarioProfesional = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPasswordProfesional = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.btnLoginProfesional = ((System.Windows.Controls.Button)(target));
            
            #line 219 "..\..\LoginProfesional.xaml"
            this.btnLoginProfesional.Click += new System.Windows.RoutedEventHandler(this.btnLoginProfesional_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
