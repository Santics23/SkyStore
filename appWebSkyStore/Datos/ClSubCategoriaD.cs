using appWebSkyStore.Entidades;
using appWebSkyStore.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Datos
{
    public class ClSubCategoriaD
    {
        public List<ClSubCategoriaE> mtdListarSubCats()
        {
            string sql = "select * from SubCategoria";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);
            List<ClSubCategoriaE> listaSubCats = new List<ClSubCategoriaE>();

            ClSubCategoriaE objDatosSub = null;

            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                objDatosSub = new ClSubCategoriaE();
                objDatosSub.idSubCategoria = int.Parse(tblDatos.Rows[i]["idSubCategoria"].ToString());
                objDatosSub.subCategoria = tblDatos.Rows[i]["subCategoria"].ToString();

                listaSubCats.Add(objDatosSub);


            }

            return listaSubCats;
        }

        
        
        public DataTable mtdObtenerProductos(string genero , string subcategs , float rangeMin ,  float rangeMax)
        {
            string sql = "SELECT Producto.nombreProducto, Producto.imagen , Producto.descripcion , Producto.precio , SubCategoria.subCategoria FROM Producto INNER JOIN SubCategoria On Producto.idSubCategoria = SubCategoria.idSubCategoria INNER JOIN Categoria ON SubCategoria.idCategoria = Categoria.idCategoria WHERE categoria LIKE '%' + '"+genero+ "' + '%' AND subCategoria LIKE '%' + '"+subcategs+ "' + '%' AND Producto.precio BETWEEN " + rangeMin+" AND "+rangeMax+"";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);

            return tblDatos;
        }

        public void mtdRepeaterP(Repeater repeater, string genero, string subcategs, float rangeMin , float rangeMax)
        {
            DataTable productos = mtdObtenerProductos(genero,subcategs , rangeMin , rangeMax);
            repeater.DataSource = productos;
            repeater.DataBind();
        }
        
        
        public DataTable mtdObtenerProductosAll()
        {
            string sql = "SELECT Producto.nombreProducto, Producto.imagen , Producto.descripcion , Producto.precio , SubCategoria.subCategoria FROM Producto INNER JOIN SubCategoria On Producto.idSubCategoria = SubCategoria.idSubCategoria";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);

            return tblDatos;
        }

        public void mtdRepeaterAll(Repeater repeater)
        {
            DataTable productos = mtdObtenerProductosAll();
            repeater.DataSource = productos;
            repeater.DataBind();
        }


    }
}