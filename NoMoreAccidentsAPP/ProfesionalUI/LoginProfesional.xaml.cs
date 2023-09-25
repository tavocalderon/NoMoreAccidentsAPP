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
using Oracle.ManagedDataAccess;
using System.Data.OracleClient;
using NoMoreAccidentsAPP.ProfesionalUI;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace NoMoreAccidentsAPP
{
    /// <summary>
    /// Lógica de interacción para LoginProfesional.xaml
    /// </summary>
    public partial class LoginProfesional : Window
    {
        public LoginProfesional()
        {
            InitializeComponent();
        }
        private void BtnLoginProfesional(object sender, RoutedEventArgs e)
        {
            LoginProfesional LoginP = new LoginProfesional();
            LoginP.Show();
        }

        private void btnCerrarProfesional_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();


        }

        private void btnLoginProfesional_Click(object sender, EventArgs e)
        {


            string usernameprofesional = txtUsuarioProfesional.Text;
            string passwordprofesional = txtPasswordProfesional.Password;

            string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

            using (Oracle.ManagedDataAccess.Client.OracleConnection connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM USUARIO WHERE user_name = :usernameprofesional AND password = :passwordprofesional";
                using (Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(":usernameprofesional", OracleDbType.Varchar2).Value = usernameprofesional;
                    cmd.Parameters.Add(":passwordprofesional", OracleDbType.Varchar2).Value = passwordprofesional;

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso");
                        // Aquí puedes abrir la siguiente ventana o realizar las acciones que correspondan
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas");



                    }
                }

            }
        }

        private void btnMinimizarProfesional_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnLoginProfesional_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    

      

}
