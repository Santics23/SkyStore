using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Datos
{
    public class ClTiendaD
    {
        public int MtdRegistrar(ClTiendaE objDatos)
        {
            string consulta = "insert into Tienda(codigoTienda, nombreTienda, descripcion, imagen, direccion, idUsuario) " +
                              "values('" + objDatos.codigoTienda + "' , '" + objDatos.nombreTienda + "' , " +
                              "'" + objDatos.descripcion + "' , '" + objDatos.imagen + "' , '" + objDatos.direccion + "' , " + objDatos.idUsuario + ")";

            ClProcesarSql objSQL = new ClProcesarSql();
            int cantReg = objSQL.mtdIUDConect(consulta);

            return cantReg;
        }

        //public int mtdValidar(string codigo)
        //{
        //    string consulta = "select count(*) from Producto where codigo='" + codigo + "'";
        //    ClProcesarSql objSql = new ClProcesarSql();
        //    int contador = objSql.mtdIUDConect(consulta);
        //    return contador;
        //}

        public DataTable mtdObtenerTiendasHome()
        {
            string sql = "SELECT TOP 7 * FROM Tienda";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);

            return tblDatos;
        }

        public void mtdRepeater(Repeater repeater)
        {
            DataTable tiendas = mtdObtenerTiendasHome();
            repeater.DataSource = tiendas;
            repeater.DataBind();
        }

        public DataTable mtdObtenerTiendas()
        {
            string sql = "SELECT * FROM Tienda";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(sql);

            return tblDatos;
        }

        public void mtdRepeaterT(Repeater repeater)
        {
            DataTable tiendas = mtdObtenerTiendas();
            repeater.DataSource = tiendas;
            repeater.DataBind();
        }

        public List<ClTiendaE> mtdListar()
        {
            string consulta = "select * from Tienda";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblTiendas = objSQL.mtdSelectDesc(consulta);

            List<ClTiendaE> listaTiendas = new List<ClTiendaE>();

            for (int i = 0; i < tblTiendas.Rows.Count; i++)
            {
                ClTiendaE objDatos = new ClTiendaE();
                objDatos.codigoTienda = tblTiendas.Rows[i]["codigoTienda"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.descripcion = tblTiendas.Rows[i]["descripcion"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.direccion = tblTiendas.Rows[i]["direccion"].ToString();
                objDatos.estado = tblTiendas.Rows[i]["estado"].ToString();

                listaTiendas.Add(objDatos);
            }
            return listaTiendas;

        }


        public List<ClTiendaE> mtdBuscart(ClTiendaE objDatos)
        {

            string consulta = "select * from Tienda where nombreTienda = '" + objDatos.nombreTienda + "'";

            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblTiendas = objSQL.mtdSelectDesc(consulta);

            List<ClTiendaE> listaTiendas = new List<ClTiendaE>();

            for (int i = 0; i < tblTiendas.Rows.Count; i++)
            {
                objDatos.codigoTienda = tblTiendas.Rows[i]["codigoTienda"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.descripcion = tblTiendas.Rows[i]["descripcion"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.direccion = tblTiendas.Rows[i]["direccion"].ToString();
                objDatos.estado = tblTiendas.Rows[i]["estado"].ToString();

                listaTiendas.Add(objDatos);
            }
            return listaTiendas;

        }

        public List<ClTiendaE> mtdListarTienda(int idUsuario)
        {

            string consulta = "SELECT * FROM Tienda Where idUsuario = "+ idUsuario +"";

            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblTiendas = objSQL.mtdSelectDesc(consulta);

            List<ClTiendaE> listaTiendas = new List<ClTiendaE>();

            ClTiendaE objDatos = null;

            for (int i = 0; i < tblTiendas.Rows.Count; i++)
            {
                objDatos = new ClTiendaE();
                objDatos.idTienda = int.Parse(tblTiendas.Rows[i]["codigoTienda"].ToString());
                objDatos.codigoTienda = tblTiendas.Rows[i]["codigoTienda"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.descripcion = tblTiendas.Rows[i]["descripcion"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.direccion = tblTiendas.Rows[i]["direccion"].ToString();
                objDatos.estado = tblTiendas.Rows[i]["estado"].ToString();

                listaTiendas.Add(objDatos);
            }
            return listaTiendas;

        }


        public int mtdEStado(ClTiendaE objDatos, string codigo)
        {
            string consulta = "update Tienda set estado = '" + objDatos.estado + "' where codigoTienda = '" + codigo + "'";

            ClProcesarSql objSQL = new ClProcesarSql();
            int cantAct = objSQL.mtdIUDConect(consulta);

            return cantAct;

        }

        public List<ClTiendaE> mtdListarTiendaAdmin(int id)
        {
            string consulta = "select * from Tienda where idUsuario = "+ id +"";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblTiendas = objSQL.mtdSelectDesc(consulta);

            List<ClTiendaE> listaTiendas = new List<ClTiendaE>();

            for (int i = 0; i < tblTiendas.Rows.Count; i++)
            {
                ClTiendaE objDatos = new ClTiendaE();
                objDatos.codigoTienda = tblTiendas.Rows[i]["codigoTienda"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.descripcion = tblTiendas.Rows[i]["descripcion"].ToString();
                objDatos.nombreTienda = tblTiendas.Rows[i]["nombreTienda"].ToString();
                objDatos.direccion = tblTiendas.Rows[i]["direccion"].ToString();
                objDatos.estado = tblTiendas.Rows[i]["estado"].ToString();

                listaTiendas.Add(objDatos);
            }
            return listaTiendas;

        }

        public ClTiendaE mtdCorreoUsu(string codigo)
        {
            string consulta = "SELECT * FROM Tienda INNER JOIN Usuario ON Tienda.idUsuario = Usuario.idUsuario WHERE codigoTienda = '" + codigo + "'";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblTiendas = objSQL.mtdSelectDesc(consulta);

            ClTiendaE objDatos = null;

            if (tblTiendas.Rows.Count > 0)
            {
                objDatos = new ClTiendaE();
                objDatos.email = tblTiendas.Rows[0]["email"].ToString();
            }
            return objDatos;
        }
    }
}