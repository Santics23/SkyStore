using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Entidades
{
    public class ClSubCategoriaE
    {
        public int idSubCategoria { get; set; }
        public string subCategoria { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public int idCategoria { get; set; }
    }
}