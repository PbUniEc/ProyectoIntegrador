using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SistemaReservas.Conexion
{
    

    public class Conexion
    {
        private readonly string cadena = "server=localhost;database=sistemareservas;uid=root;pwd=root;";
        private MySqlConnection conexion;

        public IDbConnection AbrirConexion()
        {
            conexion = new MySqlConnection(cadena);
            conexion.Open();
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
                conexion.Close();
        }
    }
}
