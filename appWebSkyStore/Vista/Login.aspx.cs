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
            Master.FindControl("footer").Visible = false;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            ClUsuarioL objUsuarioL = new ClUsuarioL();
            ClUsuarioE objDatos = objUsuarioL.mtdLogin(usuario);
            if(objDatos == null)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Datos Incorrectos!','Intentelo de Nuevo, por favor','warning');", true);
            }
            else
            {
                ClEncriptarAES encr = new ClEncriptarAES();
                string passDes = objDatos.clave;
                string passDesC = encr.descifrarTextoAES(passDes);

                if (usuario == objDatos.email && clave == passDesC)
                {
                    int idUsuario = objDatos.idUsuario;

                    ClRolUsuarioE objrol = objUsuarioL.mtdLoginrol(idUsuario);

                    int idRol = objrol.idRol;
                    if (idRol == 1)
                    {
                        Session["nombre"] = objDatos.nombre + " " + objDatos.apellido;
                        Session["id"] = idUsuario;
                        Session["rol"] = 1;
                        Session["correo"] = objDatos.email;
                        limpiar();
                        Response.Redirect("~/Vista/DatosAdmin.aspx");
                    }
                    else if (idRol == 2)
                    {
                        Session["nombre"] = objDatos.nombre + " " + objDatos.apellido;
                        Session["id"] = idUsuario;
                        Session["rol"] = 2;
                        Session["correo"] = objDatos.email;
                        limpiar();
                        Response.Redirect("~/Vista/DatosAdminT.aspx");
                    }
                    else if (idRol == 3)
                    {
                        Session["nombre"] = objDatos.nombre + " " + objDatos.apellido;
                        Session["id"] = idUsuario;
                        Session["rol"] = 3;
                        Session["correo"] = objDatos.email;
                        limpiar();
                        Response.Redirect("~/Vista/Home.aspx");
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Datos Incorrectos!','Intentelo de Nuevo, por favor','warning');", true);
                }
            }            
        }

        public void limpiar()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
    }
}