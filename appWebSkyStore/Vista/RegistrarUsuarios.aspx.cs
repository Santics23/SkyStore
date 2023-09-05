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
                Master.FindControl("footer").Visible = false;
            }

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClUsuarioE objDatosUsuario = new ClUsuarioE();

            int doc;
            if (txtDocumento.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" && txtClave.Text != "") {
                if (int.TryParse(txtDocumento.Text, out doc))
                {
                    if (doc > 0)
                    {
                        objDatosUsuario.documento = txtDocumento.Text;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡El Documento no Puede Contener Digitos Negativos!','Vuelva a Ingresar su documento','warning');", true); ;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Tiene que ser un número de Documento, no un texto!','Vuelva a Ingresar su documento','warning');", true); ;
                }
                objDatosUsuario.nombre = txtNombre.Text;
                objDatosUsuario.apellido = txtApellido.Text;

                if (int.TryParse(txtTelefono.Text, out doc))
                {
                    if (doc > 0)
                    {
                        objDatosUsuario.telefono = txtTelefono.Text;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡El Número de Telefono no Puede Contener Digitos Negativos!','Vuelva a Ingresar su Telefono','warning');", true); ;
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Tiene que ser un número de Telefono, no un texto!','Vuelva a Ingresar su Telefono','warning');", true); ;
                }
                objDatosUsuario.email = txtEmail.Text;
                objDatosUsuario.clave = txtClave.Text;
                objDatosUsuario.idRol = 3;

                ClUsuarioL objUsuarioL = new ClUsuarioL();
                int resultado = objUsuarioL.mtdRegistrar(objDatosUsuario);



                if (resultado == 1)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Usuario Registrado!','El Usuario ha Sido Registrado Con Exito','success');", true);
                    limpiar();
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Hay Algunos Datos Vacios!','Porfavor rellene Todos los Datos','info');", true);
            }
        }

        public void limpiar()
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