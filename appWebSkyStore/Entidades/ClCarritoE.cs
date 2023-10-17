using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Entidades
{
    public class ClCarritoE : ClProductoE
    {
        public int idCarrito { get; set; }
        public int cantidad { get; set; }
        public int idProducto { get; set; }
        public int idUsuario { get; set; }
    }
}