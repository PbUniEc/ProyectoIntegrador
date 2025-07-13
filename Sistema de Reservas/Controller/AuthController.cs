using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaReservas.Models;

namespace SistemaReservas.Controllers
{
    public class AuthController
    {
        public bool Login(string email, string clave)
        {
            return new LoginModel { Email = email, Clave = clave }.VerificarLogin();
        }
    }
}
