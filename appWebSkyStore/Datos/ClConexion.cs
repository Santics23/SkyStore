using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Datos
{
    public class ClConexion
    {
        SqlConnection conexion = null;

        public SqlConnection MtdConexion()
        {
            conexion = new SqlConnection("Data Source=.;Initial Catalog=dbSkyStore;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}