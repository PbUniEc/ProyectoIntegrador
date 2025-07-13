using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
    }
}
