using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
        // Clase que me define el objeto a utilizar
    {
        public int Id { get; set; }
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción Articulo")]
        public string Descripcion { get; set; }
        [DisplayName("Imágen")]
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }
        [DisplayName("Id Marca")]
        public int IdMarca { get; set; }
        [DisplayName("Descripción Marca")]
        public Marca DescripcionMarca { get; set; }
        [DisplayName("Id Categoría")]
        public int IdCategoria { get; set; }
        [DisplayName("Descripción Categoría")]
        public Categoria DescripcionCategoria { get; set; }

    }
}
