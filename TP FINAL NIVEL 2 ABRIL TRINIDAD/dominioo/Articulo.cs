using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominioo
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Marca")]
        public Marca Marca { get; set; }
        [DisplayName("Categoria")]
        public Categorias Categoria { get; set; }
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }
       
    }
}
