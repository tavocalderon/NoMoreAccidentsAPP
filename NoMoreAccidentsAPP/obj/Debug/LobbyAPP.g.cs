﻿#pragma checksum "..\..\LobbyAPP.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "087CC26A4FC0FF0B9BA4785341DFC1E2B848B6D82351ED51AD1A0D85C4D00F6C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// LobbyAPP
    /// </summary>
    public partial class LobbyAPP : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\LobbyAPP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border LobbyAPPs;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\LobbyAPP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimizarLobby;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\LobbyAPP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrarLobby;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\LobbyAPP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInicioProfesional;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\LobbyAPP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInicioAdministrador;
        
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
            System.Uri resourceLocater = new System.Uri("/NoMoreAccidentsAPP;component/lobbyapp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LobbyAPP.xaml"
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
            this.LobbyAPPs = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.btnMinimizarLobby = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\LobbyAPP.xaml"
            this.btnMinimizarLobby.Click += new System.Windows.RoutedEventHandler(this.btnMinimizarLobby_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCerrarLobby = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\LobbyAPP.xaml"
            this.btnCerrarLobby.Click += new System.Windows.RoutedEventHandler(this.btnCerrarLobby_Click_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnInicioProfesional = ((System.Windows.Controls.Button)(target));
            
            #line 184 "..\..\LobbyAPP.xaml"
            this.btnInicioProfesional.Click += new System.Windows.RoutedEventHandler(this.btnInicioProfesional_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnInicioAdministrador = ((System.Windows.Controls.Button)(target));
            
            #line 219 "..\..\LobbyAPP.xaml"
            this.btnInicioAdministrador.Click += new System.Windows.RoutedEventHandler(this.btnInicioAdministrador_Click1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

