using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Logica
{
    public class ClSubCategoriaL
    {
        public List<ClSubCategoriaE> mtdListarSub()
        {
            ClSubCategoriaD objDatos = new ClSubCategoriaD();   
            List<ClSubCategoriaE> listaSub = objDatos.mtdListarSubCats();
            return listaSub;
        }

        
        public void mtdRepeater(Repeater repeater , string genero, string subcategs, float rangeMin, float rangeMax)
        {
            ClSubCategoriaD objDatosMujer = new ClSubCategoriaD();
            objDatosMujer.mtdRepeaterP(repeater, genero, subcategs, rangeMin, rangeMax);
        }

        
        public void mtdRepeaterAll(Repeater repeater)
        {
            ClSubCategoriaD objDatosInfantil = new ClSubCategoriaD();
            objDatosInfantil.mtdRepeaterAll(repeater);
        }
     
    }
}