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
    public partial class RegistrarAdminTienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            objDatosUsuario.idRol = 2;



            ClUsuarioL objUsuarioL = new ClUsuarioL();



            int validar = objUsuarioL.mtdValidar(objDatosUsuario);



            if (txtDocumento.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtTelefono.Text == "" || txtEmail.Text == "" || txtClave.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Campos Vacios!','Vaya, Parece Que Tienes Espacios Vacios','info');", true);

            }
            else
            {
                if (validar == 1)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡ERROR!','Este Usuario Ya Se Encuentra Registrado','warning');", true);
                    mtdlimpiar();

                }

                else if (validar == 0)
                {
                    int resultado = objUsuarioL.mtdRegistrar(objDatosUsuario);
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Usuario Registrado!','El Usuario Ha Sido Registrado Con Exito','success');", true);
                    mtdlimpiar();
                }

            }

        }

        public void mtdlimpiar()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtClave.Text = "";
        }
    }
}