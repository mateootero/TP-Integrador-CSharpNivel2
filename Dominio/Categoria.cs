using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        // Sobreescribir el metodo "ToString"
        public override string ToString()
        {
            return DescripcionCategoria;
        }
    }
}
