using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace NoMoreAccidents.DALC
{
    public class Conexion
    {
        string conexionstring = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;



        public void Conectar()
        {
            try
            {
                OracleConnection conexion = new OracleConnection(conexionstring);
                conexion.Open();
                MessageBox.Show("Conexión Exitosa");
                // Aquí puedes realizar otras operaciones con la conexión si es necesario
            }
            catch (OracleException ex)
            {
                // Manejo de excepciones de Oracle
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otras excepciones
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

