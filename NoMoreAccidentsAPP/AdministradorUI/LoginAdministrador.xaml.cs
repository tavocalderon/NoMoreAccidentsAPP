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
using NoMoreAccidentsAPP;
using NoMoreAccidentsAPP.AdministradorUI;


namespace NoMoreAccidentsAPP
{
    /// <summary>
    /// Lógica de interacción para LoginAdministrador.xaml
    /// </summary>
    public partial class LoginAdministrador : Window
    {
        public LoginAdministrador()
        {
            InitializeComponent();
        }



        private void dasada(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarAdministrador_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        

             private void BtnLoginAdministrador_Click(object sender, RoutedEventArgs e)
        {



           MenuADM MAdmin = new MenuADM();
            MAdmin.ShowDialog();

        }

        private void txtUsuarioAdministrador_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCerrarAdministrador_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }








}
