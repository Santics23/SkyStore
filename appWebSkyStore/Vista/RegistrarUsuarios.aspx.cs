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
    public partial class RegistrarUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClUsuarioE objDatosUsuario = new ClUsuarioE();

            objDatosUsuario.documento = txtDocumento.Text;
            objDatosUsuario.nombre = txtNombre.Text;
            objDatosUsuario.apellido = txtApellido.Text;
            objDatosUsuario.telefono = txtTelefono.Text;
            objDatosUsuario.email = txtEmail.Text;
            objDatosUsuario.clave = txtClave.Text;
            objDatosUsuario.idRol = 3;

            ClUsuarioL objUsuarioL = new ClUsuarioL();
            int resultado = objUsuarioL.mtdRegistrar(objDatosUsuario);
           


            if (resultado == 1 )
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Usuario Registrado!','El Usuario ha Sido Registrado Con Exito','success');", true); ;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Usuario No Registrado!','El Usuario No ha Sido Registrado Con Exito','warning');", true); 

            }
        }
    }
}