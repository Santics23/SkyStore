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
    public partial class PerfilAdminT : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mtdLlenarDatos();
            }            
        }

        ClUsuarioE objDatosUsuario = null;
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            objDatosUsuario = new ClUsuarioE();

            objDatosUsuario.documento = txtDocumento.Text;

            objDatosUsuario.nombre = txtNombre.Text;
            objDatosUsuario.apellido = txtApellido.Text;

            objDatosUsuario.telefono = txtTelefono.Text;

            objDatosUsuario.email = txtEmail.Text;


            ClEncriptarAES encrypAES = new ClEncriptarAES();

            string contraseñaEn = txtClave.Text;
            string lp = encrypAES.cifrarTextoAES(contraseñaEn);
            objDatosUsuario.clave = lp;
            int id = int.Parse(Session["id"].ToString());
            ClUsuarioL objUsuarioL = new ClUsuarioL();
            int resultado = objUsuarioL.mtdEditar(objDatosUsuario, id);



            if (resultado == 1)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Usuario Editado!','El Usuario ha Sido Editado Con Exito','success');", true);
                mtdLlenarDatos();
            }
        }

        public void mtdLlenarDatos()
        {
            ClUsuarioL objUsuarioL = new ClUsuarioL();
            ClUsuarioE objDatosUsuario = objUsuarioL.mtdListarDatos(int.Parse(Session["id"].ToString()));
            txtDocumento.Text = objDatosUsuario.documento;
            txtNombre.Text = objDatosUsuario.nombre;
            txtApellido.Text = objDatosUsuario.apellido;
            txtTelefono.Text = objDatosUsuario.telefono;
            txtEmail.Text = objDatosUsuario.email;
            ClEncriptarAES encrypAES = new ClEncriptarAES();

            string passDes = objDatosUsuario.clave;
            string passDesC = encrypAES.descifrarTextoAES(passDes);
            txtClave.Text = passDesC;
        }
    }
}
