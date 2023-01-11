using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEsplorando.Models
{
    public static class IntExtensao
    {
        public static bool Ehpar(this int numero)
        {
            return numero % 2 == 0;
        }
        
    }
}