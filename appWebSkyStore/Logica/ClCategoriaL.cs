using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Logica
{
    public class ClCategoriaL
    {
        public List<ClCategoriaE> mtdListar()
        {
            ClCategoriaD objRol = new ClCategoriaD();
            List<ClCategoriaE> listaCategoria = objRol.MtdCargaCombo();
            return listaCategoria;

        }

        public void mtdRepeaterCateg(Repeater repeater, string categs)
        {
            ClCategoriaD objDatos = new ClCategoriaD();
            objDatos.mtdRepeaterCategs(repeater,categs);
        }
    }
}