using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Entidades
{
    public class ClSubCategoriaE : ClCategoriaE
    {
        public int idSubCategoria { get; set; }
        public string subCategoria { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public new int idCategoria { get; set; }
    }
}