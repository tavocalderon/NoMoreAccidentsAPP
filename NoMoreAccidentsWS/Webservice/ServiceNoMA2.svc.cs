using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace NoMoreAccidentsWS.Webservice
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceNoMA2" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceNoMA2.svc o ServiceNoMA2.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceNoMA2 : IServiceNoMA2
    {
        public bool ValidateLogin(string username, string password)
        {
            // Conectar a la base de datos
            SqlConnection connection = new SqlConnection("DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED));User Id=BD_NoMA;Password=PTY.duoc.2023;");
            connection.Open();

            // Crear una consulta
            SqlCommand command = new SqlCommand("SELECT * FROM AUTH_USERS WHERE nombre = @username AND contraseña = @password", connection);
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
    }
}
