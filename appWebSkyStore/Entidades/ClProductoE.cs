using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Entidades
{
    public class ClProductoE : ClSubCategoriaE
    {
        public int idProducto { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public float Precio { get; set; }

        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public int Stock { get; set; }

        public string Estado { get; set; }

        public string Promocion { get; set; }

        public double Descuento { get; set; }

        public new int idSubCategoria { get; set; }
    }
}