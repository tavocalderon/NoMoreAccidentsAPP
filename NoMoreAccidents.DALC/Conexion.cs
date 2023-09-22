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
            OracleConnection conexion = new OracleConnection(conexionstring);
            conexion.Open();
            MessageBox.Show("Conexion Exitosa");
        }
    }
}

