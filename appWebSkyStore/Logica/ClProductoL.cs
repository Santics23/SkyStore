﻿using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Logica
{
    public class ClProductoL
    {
        public int mtdRegistrar(ClProductoE objDatos)
        {
            ClProductoD objdatosD = new ClProductoD();
            int reg = objdatosD.MtdRegistrar(objDatos);
            return reg;

        }

        //public int mtdCodigo(string codigo)
        //{
        //    ClProductoD objProducto = new ClProductoD();
        //    int contador = objProducto.mtdValidar(codigo);

        //    return contador;

        //}

        public List<ClProductoE> mtdListarP(string busqueda)
        {
            ClProductoD objProduct = new ClProductoD();
            List<ClProductoE> listaD = objProduct.mtdListarProducts(busqueda);
            return listaD;
        }

        public void mtdRepeater(Repeater repeater)
        {
            ClProductoD objDatos = new ClProductoD();
            objDatos.mtdRepeater(repeater);
        }

        public void mtdRepeaterSearch(Repeater repeater, string busqueda)
        {
            ClProductoD objDatos = new ClProductoD();
            objDatos.mtdRepeaterSearch(repeater, busqueda);
        }

        public List<ClProductoE> mtdListar()
        {
            ClProductoD objProductoD = new ClProductoD();
            List<ClProductoE> listarProducto = objProductoD.mtdListTable();
            return listarProducto;
        }

        
        public List<ClProductoE> mtdIdPersonal(int idProducto)
        {
            ClProductoD objProductoD = new ClProductoD();
            List<ClProductoE> listaTable = objProductoD.mtdObtenerProductoPorId(idProducto);
            return listaTable;
        }

        public int mtdActualizacion(ClProductoE objDatos)
        {
            ClProductoD objProductoD = new ClProductoD();
            int actu = objProductoD.mtdActualizar(objDatos);
            return actu;
        }

        public int mtdEliminar(ClProductoE objDatos)
        {
            ClProductoD objProductoD = new ClProductoD();
            int Eliminar = objProductoD.mtdEliminar(objDatos);
            return Eliminar;
        }

    }
}
