using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class RegistrarTienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                formularioPanel.Visible = true;
                Panel1.Visible = false;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {

            string imagen = "";

            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDescripcion.Text == "" || txtDireccion.Text == "")
            {
                string mens = "Vaya, Parece Que Tienes Espacios Vacios";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Campos Vacios','" + mens + "', 'info')", true);
            }
            else
            {
                ClTiendaE objTiendaE = null;
                if (fileUpload.HasFile)
                {
                    imagen = txtCodigo.Text + ".png";
                    string rutaImg = Server.MapPath("~/Vista/imagesG/" + imagen);
                    fileUpload.SaveAs(rutaImg);

                    string codigo = txtCodigo.Text;
                    ClTiendaL obTiendaL = new ClTiendaL();
                    //int contador = obTiendaL.mtdCodigo(codigo);
                    objTiendaE = new ClTiendaE();
                    objTiendaE.codigoTienda = txtCodigo.Text;
                    objTiendaE.nombreTienda = txtNombre.Text;
                    objTiendaE.descripcion = txtDescripcion.Text;
                    objTiendaE.imagen = imagen;
                    objTiendaE.direccion = txtDireccion.Text;
                    objTiendaE.idUsuario = 1;
                    objTiendaE.estado = "Inactiva";
                    ClTiendaL objTiendaL = new ClTiendaL();
                    int registrar = objTiendaL.mtdRegistrarT(objTiendaE);

                    if (registrar == 1)
                    {
                        Limpiar();
                        formularioPanel.Visible = false;
                        Panel1.Visible = true;
                        string mens = "Su tienda ha sido registrada con exito, FELICIDADES";
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Tienda Registrada!','" + mens + "', 'success')", true);
                    }
                }
                else
                {
                    string mens = "Debe seleccionar una imagen para su tienda";
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Seleccion Imagen','" + mens + "', 'info')", true);
                }
            }



        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

            string body = "Bievenido a SkyStore" +
                " Estimado Usuario" +
                " Le solicitamos por favor el rut y la camara de comercio de su tienda" +
                " Le pedimos que nos responda lo mas antes posible para validar sus datos y verificar su tienda" +
                " Gracias por su atecion quedamos atentos a cualquier inquietud" +
                " Coridal Saludos";


            MailMessage message = new MailMessage();
            message.To.Add(txtCorreo.Text);
            message.Subject = "Sky Store";
            message.Body = body;
            message.From = new MailAddress("rdmorales40@misena.edu.co");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("rdmorales40@misena.edu.co", "12345678");
            smtpClient.Send(message);


            if (txtCorreo.Text == "")
            {
                string mens = "Por favor ingrese el correo electronico";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Campos Vacios','" + mens + "', 'info')", true);

            }
            else
            {
                string mens = "Por favor revise su correo electronico";
                ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('¡Correo Enviado!','" + mens + "', 'success')", true);
            }

        }

    }
}
