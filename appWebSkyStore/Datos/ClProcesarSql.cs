using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Datos
{
    public class ClProcesarSql
    {
        //Ejecuta Consulta select en forma desconectada y retorna DataTable

        public DataTable mtdSelectDesc(string consulta)
        {
            ClConexion objConexion = new ClConexion();

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, objConexion.MtdConexion());
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            objConexion.MtdConexion().Close();

            return tblDatos;
        }

        //Ejecuta SQL Insert, Update,Delete en forma conectada y retorna entero

        public int mtdIUDConect(string consulta)
        {
            ClConexion objConexion = new ClConexion();

            SqlCommand comando = new SqlCommand(consulta, objConexion.MtdConexion());
            int registros = comando.ExecuteNonQuery();
            objConexion.MtdConexion().Close();

            return registros;
        }

        public SqlCommand mtdIUDConect2(string ProcesoAlmacenado)
        {
            ClConexion objConexion = new ClConexion();
            SqlCommand comando = new SqlCommand(ProcesoAlmacenado, objConexion.MtdConexion());
            comando.CommandType = CommandType.StoredProcedure;
            return comando;
        }

    }
}