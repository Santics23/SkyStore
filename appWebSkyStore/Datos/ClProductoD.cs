using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Datos
{
    public class ClProductoD
    {
        public int MtdRegistrar(ClProductoE objDatos)
        {

            String consulta = "insert into Producto(codigoProducto,nombreProducto,precio,descripcion,imagen,stock,estado,idSubCategoria)" +
                                "values('" + objDatos.Codigo + "','" + objDatos.Nombre + "'," + objDatos.Precio + ",'" +
                                objDatos.Descripcion + "','" + objDatos.Imagen + "'," + objDatos.Stock + ",'" + objDatos.Estado + "'," + objDatos.idSubCategoria + ")";

            ClProcesarSql objSQL = new ClProcesarSql();
            int canReg = objSQL.mtdIUDConect(consulta);
            return canReg;

        }

        //public int mtdValidar(string codigo)
        //{
        //    string consulta = "select count(*) from Articulo where codigo='" + codigo + "'";
        //    ClProcesarSql objSql = new ClProcesarSql();
        //    int contador = objSql.mtdIUDConect(consulta);

        //    return contador;
        //}

        public List<ClProductoE> mtdListarProducts(string busqueda)
        {
            string consulta = "SELECT Producto.nombreProducto, Producto.imagen , Producto.descripcion , Producto.precio , SubCategoria.subCategoria FROM Producto INNER JOIN SubCategoria On Producto.idSubCategoria = SubCategoria.idSubCategoria WHERE nombreProducto LIKE '%' + '" + busqueda + "' + '%' OR subCategoria LIKE '%' + '" + busqueda + "' + '%'";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(consulta);
            List<ClProductoE> listaData = new List<ClProductoE>();

            ClProductoE objDatosRol = null;

            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                objDatosRol = new ClProductoE();
                objDatosRol.Nombre = tblDatos.Rows[i]["nombreProducto"].ToString();
                objDatosRol.subCategoria = tblDatos.Rows[i]["subCategoria"].ToString();

                listaData.Add(objDatosRol);

            }

            return listaData;
        }

        public DataTable mtdObtenerProductos()
        {
            string sql = "SELECT TOP 12 Producto.nombreProducto, Producto.imagen , Producto.descripcion , Producto.precio , SubCategoria.subCategoria FROM Producto INNER JOIN SubCategoria On Producto.idSubCategoria = SubCategoria.idSubCategoria";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);

            return tblDatos;
        }

        public void mtdRepeater(Repeater repeater)
        {
            DataTable productos = mtdObtenerProductos();
            repeater.DataSource = productos;
            repeater.DataBind();
        }

        public DataTable mtdBusqueda(string busqueda)
        {
            string consulta = "SELECT Producto.nombreProducto, Producto.imagen , Producto.descripcion , Producto.precio , SubCategoria.subCategoria FROM Producto INNER JOIN SubCategoria On Producto.idSubCategoria = SubCategoria.idSubCategoria INNER JOIN Categoria On SubCategoria.idCategoria = Categoria.idCategoria WHERE nombreProducto LIKE '%" + busqueda + "%' OR categoria LIKE '%" + busqueda + "%' OR subCategoria LIKE '%" + busqueda + "%'";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(consulta);

            return tblDatos;
        }

        public void mtdRepeaterSearch(Repeater repeater, string busqueda)
        {
            DataTable productos = mtdBusqueda(busqueda);
            repeater.DataSource = productos;
            repeater.DataBind();
        }

        public List<ClProductoE> mtdListTable()
        {

            string Consulta = "SELECT * FROM Producto";

            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tbl = objSQL.mtdSelectDesc(Consulta);
            List<ClProductoE> ListarProducto = new List<ClProductoE>();
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ClProductoE objProductE = new ClProductoE();
                objProductE.idProducto = int.Parse(tbl.Rows[i]["idProducto"].ToString());
                objProductE.Codigo = tbl.Rows[i]["codigoProducto"].ToString();
                objProductE.Nombre = tbl.Rows[i]["nombreProducto"].ToString();
                objProductE.Precio = float.Parse(tbl.Rows[i]["precio"].ToString());
                objProductE.Descripcion = tbl.Rows[i]["descripcion"].ToString();
                objProductE.Imagen = tbl.Rows[i]["imagen"].ToString();
                objProductE.Stock = int.Parse(tbl.Rows[i]["stock"].ToString());
                objProductE.Estado = tbl.Rows[i]["estado"].ToString();
                objProductE.Promocion = tbl.Rows[i]["promocion"].ToString();
                objProductE.idSubCategoria = int.Parse(tbl.Rows[i]["idSubCategoria"].ToString());

                ListarProducto.Add(objProductE);


            }
            return ListarProducto;
        }


        public List<ClProductoE> mtdObtenerProductoPorId(int idProducto)
        {

            string Consulta = "SELECT * FROM Producto WHERE idProducto = " + idProducto;

            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tbl = objSQL.mtdSelectDesc(Consulta);
            List<ClProductoE> ListarProducto = new List<ClProductoE>();

            float descuento = 0;
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                ClProductoE objProductE = new ClProductoE();
                objProductE.idProducto = int.Parse(tbl.Rows[i]["idProducto"].ToString());
                objProductE.Codigo = tbl.Rows[i]["codigoProducto"].ToString();
                objProductE.Nombre = tbl.Rows[i]["nombreProducto"].ToString();
                objProductE.Precio = float.Parse(tbl.Rows[i]["precio"].ToString());
                objProductE.Descripcion = tbl.Rows[i]["descripcion"].ToString();
                objProductE.Imagen = tbl.Rows[i]["imagen"].ToString();
                objProductE.Stock = int.Parse(tbl.Rows[i]["stock"].ToString());
                objProductE.Estado = tbl.Rows[i]["estado"].ToString();
                objProductE.Promocion = tbl.Rows[i]["promocion"].ToString();                                
                if (objProductE.Descuento == 0)
                {
                    objProductE.Descuento = descuento;
                }
                else
                {
                    objProductE.Descuento = float.Parse(tbl.Rows[i]["descuento"].ToString());
                }
                objProductE.idSubCategoria = int.Parse(tbl.Rows[i]["idSubCategoria"].ToString());

                ListarProducto.Add(objProductE);


            }
            return ListarProducto;

        }

        public int mtdActualizar(ClProductoE objDatos)
        {
            string ProcesosAlmacenado = "ActualizarProducto";
            ClProcesarSql objSQL = new ClProcesarSql();
            SqlCommand Actualizar = objSQL.mtdIUDConect2(ProcesosAlmacenado);

            Actualizar.Parameters.AddWithValue("@Codigo", objDatos.Codigo);
            Actualizar.Parameters.AddWithValue("@Nombre", objDatos.Nombre);
            Actualizar.Parameters.AddWithValue("@Precio", objDatos.Precio);
            Actualizar.Parameters.AddWithValue("@Descripcion", objDatos.Descripcion);
            Actualizar.Parameters.AddWithValue("@Imagen", objDatos.Imagen);
            Actualizar.Parameters.AddWithValue("@Stock", objDatos.Stock);
            Actualizar.Parameters.AddWithValue("@Estado", objDatos.Estado);
            Actualizar.Parameters.AddWithValue("@Promocion", objDatos.Promocion);
            Actualizar.Parameters.AddWithValue("@Descuento", objDatos.Descuento);
            Actualizar.Parameters.AddWithValue("@idSubCategoria", objDatos.idSubCategoria);
            Actualizar.Parameters.AddWithValue("@idProducto", objDatos.idProducto);

            int DatosActualizar = Actualizar.ExecuteNonQuery();
            return DatosActualizar;
        }
        public int mtdEliminar(ClProductoE objDatos)
        {
            string ProcesosAlmacenado = "EliminarRegistro";

            ClProcesarSql objSQL = new ClProcesarSql();
            SqlCommand Eliminar = objSQL.mtdIUDConect2(ProcesosAlmacenado);

            Eliminar.Parameters.AddWithValue("@idProducto", objDatos.idProducto);

            int DatosActualizar = Eliminar.ExecuteNonQuery();
            return DatosActualizar;

        }
    }
}