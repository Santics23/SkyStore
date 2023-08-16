using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Entidades
{
    public class ClTiendaE
    {
        public int idTienda { get; set; }
        public string codigoTienda { get; set; }
        public string nombreTienda { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public string direccion { get; set; }
        public string estado { get; set; }
        public int idUsuario { get; set; }
    }
}