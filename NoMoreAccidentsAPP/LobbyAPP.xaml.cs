using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NoMoreAccidentsAPP.AdministradorUI;
using NoMoreAccidentsAPP.ProfesionalUI;


namespace NoMoreAccidentsAPP
{
    /// <summary>
    /// Lógica de interacción para LobbyAPP.xaml
    /// </summary>
    public partial class LobbyAPP : Window
    {
        public LobbyAPP()
        {
            InitializeComponent();
        }
        
        public void btnInicioProfesional_Click(object sender, RoutedEventArgs e)
        {
            LoginProfesional InicioProfesional = new LoginProfesional();
            this.Hide();
            InicioProfesional.ShowDialog();
        }


        private void btnCerrarLobby_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarLobby_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnInicioAdministrador_Click1(object sender, RoutedEventArgs e)
        {
            LoginAdministrador InicioAdministrador = new LoginAdministrador();
            this.Hide();
            InicioAdministrador.ShowDialog();

        }
    }
}
