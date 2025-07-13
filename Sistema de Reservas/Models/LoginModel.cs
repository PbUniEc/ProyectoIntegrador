using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Clave { get; set; }
        private Conexion.Conexion _conexion = new Conexion.Conexion();

        public bool VerificarLogin()
        {
            using (var con = _conexion.AbrirConexion())
            {
                string sql = "SELECT * FROM usuarios WHERE email = @email AND clave = SHA2(@clave, 256)";
                MySqlCommand cmd = new MySqlCommand(sql, (MySqlConnection)con);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@clave", Clave);

                using (var dr = cmd.ExecuteReader())
                    return dr.HasRows;
            }
        }
    }
}
