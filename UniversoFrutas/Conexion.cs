using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversoFrutas
{
    internal class Conexion
    {
        private String server = "localhost";
        private String databse = "universo";
        private String user = "root";
        private String password = "";
        private String cadenaConexion;
        private MySqlConnection conexion;


        public Conexion() {

            cadenaConexion = "Database = " + databse +
            "; DataSource = " + server +
            "; User Id = " + user +
            "; Password = " + password;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            else if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }


        public void CerrarConexion()
        {
            if (conexion != null && conexion.State != ConnectionState.Closed)
            {
                conexion.Close();
            }
        }
    }

 }

