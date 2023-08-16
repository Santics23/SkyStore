using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class Login : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            ClUsuarioL objUsuarioL = new ClUsuarioL();
            ClUsuarioE objDatos = objUsuarioL.mtdLogin(usuario, clave);
            int idUsuario = objDatos.idUsuario;

            ClRolUsuarioE objrol = objUsuarioL.mtdLoginrol(idUsuario);

            int idRol = objrol.idRol;

            if (objDatos != null)
            {
                if (idRol == 1)
                {
                    Session["nombre"] = objDatos.nombre;                    
                    Response.Redirect("~/Vista/DatosAdmin.aspx");
                    Master.FindControl("Logsign").Visible = false;
                }
                else if (idRol == 2)
                {
                    Session["nombre"] = objDatos.nombre;
                    Response.Redirect("~/Vista/DatosAdminT.aspx");
                    Master.FindControl("Logsign").Visible = false;
                }
                else if( idRol == 3)
                {
                    Session["nombre"] = objDatos.nombre;         
                    Response.Redirect("~/Vista/Home.aspx");
                    Master.FindControl("Logsign").Visible = false;
                }
                
            }   
        }
    }
}