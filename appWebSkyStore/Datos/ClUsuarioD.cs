using appWebSkyStore.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Datos
{
    public class ClUsuarioD
    {
        
        public ClUsuarioE mtdLogin(string email, string clave)
        {
            
            string consulta = "select * from Usuario where email = '" + email + "' and clave = '" + clave + "'";

            ClProcesarSql objSQL = new ClProcesarSql();

            DataTable tblDatos = objSQL.mtdSelectDesc(consulta);

            ClUsuarioE objUsuarioE = null;

            if (tblDatos.Rows.Count > 0)
            {
                objUsuarioE = new ClUsuarioE();
                objUsuarioE.idUsuario = int.Parse(tblDatos.Rows[0]["idUsuario"].ToString());
                objUsuarioE.documento = tblDatos.Rows[0]["documento"].ToString();
                objUsuarioE.nombre = tblDatos.Rows[0]["nombre"].ToString();
                objUsuarioE.apellido = tblDatos.Rows[0]["apellido"].ToString();
                objUsuarioE.telefono = tblDatos.Rows[0]["telefono"].ToString();
                objUsuarioE.email = tblDatos.Rows[0]["email"].ToString();
                objUsuarioE.clave = tblDatos.Rows[0]["clave"].ToString();

            }
            return objUsuarioE;
        }

        public ClRolUsuarioE mtdLoginRol(int idUsuario)
        {
            string consulta = "select * from RolUsuario where idUsuario = " + idUsuario + "";

            ClProcesarSql objSQL = new ClProcesarSql();

            DataTable tblDatos = objSQL.mtdSelectDesc(consulta);

            ClRolUsuarioE objUsuarioE = null;

            if (tblDatos.Rows.Count > 0)
            {
                objUsuarioE = new ClRolUsuarioE();      
                objUsuarioE.idUsuario = int.Parse(tblDatos.Rows[0]["idUsuario"].ToString());  
                
                objUsuarioE.idRol = int.Parse(tblDatos.Rows[0]["idRol"].ToString());  
                
                
            }
            return objUsuarioE; 
        }

        public int MtdRegistrar(ClUsuarioE objDatos)
        {
            int cantReg = 0;
            string consulta = "insert into Usuario(documento, nombre, apellido, telefono, email, clave) " +
                              "values('" + objDatos.documento + "' , '" + objDatos.nombre + "' , " +
                              "'" + objDatos.apellido + "' , '" + objDatos.telefono + "' , '" + objDatos.email + "' , '" + objDatos.clave + "') SELECT SCOPE_IDENTITY() AS [ultimoId]";



            ClProcesarSql objSQL = new ClProcesarSql();

            DataTable tblID = objSQL.mtdSelectDesc(consulta);
            int idReg = int.Parse(tblID.Rows[0]["ultimoId"].ToString());
            int idRol = objDatos.idRol;

            string consulta2 = "INSERT INTO RolUsuario(idUsuario, idRol) VALUES ("+idReg+", "+idRol+")";

            cantReg = objSQL.mtdIUDConect(consulta2);
            return cantReg;
        }

        public ClUsuarioE mtdFiltro(string documento)
        {
            string consulta = "select * from Usuario where documento='" + documento + "'";
            ClProcesarSql objSQL = new ClProcesarSql();
            DataTable tblDatos = objSQL.mtdSelectDesc(consulta);


            ClUsuarioE objUsuarioE = new ClUsuarioE();
            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                objUsuarioE = new ClUsuarioE();
                objUsuarioE.documento = tblDatos.Rows[0]["documento"].ToString();

            }
            return objUsuarioE;

        }

        public int mtdVerificarusuario(ClUsuarioE objUsuario)
        {
            string consulta = "select * from Usuario where documento = '" + objUsuario.documento + "'";
            ClProcesarSql sql = new ClProcesarSql();
            DataTable Verificar = sql.mtdSelectDesc(consulta);

            return Verificar.Rows.Count;

        }

        public List<ClUsuarioE> mtdListarUsuario()
        {
            string consulta = "select * from Usuario";

            ClProcesarSql objSql = new ClProcesarSql();
            DataTable tblDatos = objSql.mtdSelectDesc(consulta);

            //Pasar datos del DataTable a la Lista

            List<ClUsuarioE> listarUsu = new List<ClUsuarioE>();
            ClUsuarioE objDatosUsu = null;


            for (int i = 0; i < tblDatos.Rows.Count; i++)
            {
                objDatosUsu = new ClUsuarioE();
                objDatosUsu.idRol = int.Parse(tblDatos.Rows[i]["idRol"].ToString());
                objDatosUsu.rol = tblDatos.Rows[i]["rol"].ToString();
                listarUsu.Add(objDatosUsu);
            }

            return listarUsu;
        }
    }
}