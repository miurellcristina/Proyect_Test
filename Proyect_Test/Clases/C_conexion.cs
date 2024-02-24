using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyect_Test.Clases
{
    class C_conexion
    {
        SqlConnection conectar = new SqlConnection();
        static string 
            servidor = "localhost",
            DB = "DB_proyect",
            user = "userPT",
            password = "12345678",
            port = "1433";

        string coneccion = "Data Source=" + servidor + "," + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "Initial Catalog=" + DB + ";" + "Persist Security Info=true";

        public  SqlConnection establecerConexion()
        {
            try
            {
                conectar.ConnectionString = coneccion;
                conectar.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se logró conectar a la Base de Datos" + e.ToString());
            }

            return conectar;
        }

        /* Comprobar conexion
          Clases.C_conexion objetoConexion = new Clases.C_conexion();
        objetoConexion.establecerConexion(); */

    }
}
