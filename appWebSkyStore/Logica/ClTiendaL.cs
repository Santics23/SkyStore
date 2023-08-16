using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Logica
{
    public class ClTiendaL
    {
        public int mtdRegistrarT(ClTiendaE objDatos)
        {
            ClTiendaD objTiendaD = new ClTiendaD();
            int regis = objTiendaD.MtdRegistrar(objDatos);

            return regis;
        }

        //public int mtdCodigo(string codigo)
        //{
        //    ClTiendaD objProducto = new ClTiendaD();
        //    int contador = objProducto.mtdValidar(codigo);
        //    return contador;
        //}

        public void mtdRepeaterTienda(Repeater repeater)
        {
            ClTiendaD objDatos = new ClTiendaD();
            objDatos.mtdRepeater(repeater);
        }

        public void mtdRepeaterT(Repeater repeater)
        {
            ClTiendaD objDatos = new ClTiendaD();
            objDatos.mtdRepeaterT(repeater);
        }

        public List<ClTiendaE> mtdListar()
        {
            ClTiendaD objTienda = new ClTiendaD();
            List<ClTiendaE> listatiendas = objTienda.mtdListar();

            return listatiendas;
        }

        public List<ClTiendaE> mtdBuscar(ClTiendaE objDatos)
        {
            ClTiendaD objTienda = new ClTiendaD();
            List<ClTiendaE> listaTiendas = objTienda.mtdBuscart(objDatos);

            return listaTiendas;


        }


        public int mtdestado(ClTiendaE objDatos, string codigo)
        {
            ClTiendaD objTienda = new ClTiendaD();
            int catAct = objTienda.mtdEStado(objDatos, codigo);

            return catAct;

        }
    }
}