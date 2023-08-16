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
            conexion = new SqlConnection("Data Source=.;Initial Catalog=dbSkyStore;Persist Security Info=True;User ID=SantiagoCastillo;Password=123456789");
            conexion.Open();
            return conexion;
        }
    }
}