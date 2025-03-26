using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Semente.Utils
{
    internal class GerarHash
    {
        public static string GerarHashSenha(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

    }
}
