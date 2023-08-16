using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Datos
{
    public class ClCategoriaD
    {

        public List<ClCategoriaE> MtdCargaCombo()
        {
            string sql = "select * from Categoria";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);
            List<ClCategoriaE> listaCategoria = new List<ClCategoriaE>();

            ClCategoriaE objDatosRol = null;

            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                objDatosRol = new ClCategoriaE();
                objDatosRol.idCategoria = int.Parse(tblDatos.Rows[i]["idCategoria"].ToString());
                objDatosRol.Categoria = tblDatos.Rows[i]["categoria"].ToString();

                listaCategoria.Add(objDatosRol);

            }

            return listaCategoria;
        }


        public DataTable mtdObtenerCategs(string categ)
        {
            string sql = "SELECT Producto.nombreProducto, Producto.imagen , Producto.descripcion , Producto.precio , SubCategoria.subCategoria FROM Producto INNER JOIN SubCategoria On Producto.idSubCategoria = SubCategoria.idSubCategoria INNER JOIN Categoria ON SubCategoria.idCategoria = Categoria.idCategoria WHERE categoria = '" + categ + "'";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);

            return tblDatos;
        }

        public void mtdRepeaterCategs(Repeater repeater, string categ)
        {
            DataTable productos = mtdObtenerCategs(categ);
            repeater.DataSource = productos;
            repeater.DataBind();
        }




    }
}