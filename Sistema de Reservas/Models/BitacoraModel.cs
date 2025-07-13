using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservas.Models
{
    public class BitacoraModel
    {
        public int IdBitacora { get; set; }
        public int IdUsuario { get; set; }
        public string Accion { get; set; }
        public string IP { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
