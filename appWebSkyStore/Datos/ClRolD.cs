using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appWebSkyStore.Datos
{
    public class ClRolD
    {
        public List<ClRolE> mtdListar()
        {
            string consulta = "select * from Rol";

            ClProcesarSql objSql = new ClProcesarSql();
            DataTable tblDatos = objSql.mtdSelectDesc(consulta);

            //Pasar datos del DataTable a la Lista

            List<ClRolE> listarRoles = new List<ClRolE>();
            ClRolE objDatosRol = null;


            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                objDatosRol = new ClRolE();
                objDatosRol.idRol = int.Parse(tblDatos.Rows[i]["idRol"].ToString());
                objDatosRol.rol = tblDatos.Rows[i]["rol"].ToString();
                listarRoles.Add(objDatosRol);
            }

            return listarRoles;
        }
    }
}