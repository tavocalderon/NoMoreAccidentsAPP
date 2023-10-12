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
using NoMoreAccidentsAPP.AdministradorUI;
using System.Data.SqlClient;



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

        public bool ValidateLogin(string username, string password)
        {
            // Conectar a la base de datos
            SqlConnection connection = new SqlConnection();
            connection.Open();

            // Crear una consulta
            SqlCommand command = new SqlCommand("SELECT * FROM USUARIOSVIP WHERE username = @username AND contraseña = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            // Ejecutar la consulta
            SqlDataReader reader = command.ExecuteReader();

            // Si la consulta devuelve un registro, el usuario es válido
            if (reader.HasRows)
            {
                reader.Close();
                connection.Close();
                return true;
            }

            // Si la consulta no devuelve un registro, el usuario no es válido
            reader.Close();
            connection.Close();
            return false;
        }
    

    private void BtnLoginAdministrador_Click(object sender, RoutedEventArgs e)
        {

            // Obtener los datos de inicio de sesión del usuario
            string username = txtUsuarioAdministrador.Text;
            string password = txtPasswordAdministrador.Password;

            // Validar los datos de inicio de sesión
            bool isAuthenticated = ValidateLogin(username, password);

            // Mostrar un mensaje al usuario
            if (isAuthenticated)
            {
                MessageBox.Show("Inicio de sesión correcto.");
            }
            else
            {
                MessageBox.Show("Inicio de sesión incorrecto.");
            }
        }

        private void btnCerrarAdministrador_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}









