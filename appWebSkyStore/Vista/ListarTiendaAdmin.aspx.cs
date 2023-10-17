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
    public partial class ListarTiendaAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClTiendaL objTienda = new ClTiendaL();
                List<ClTiendaE> listaTienda = objTienda.mtdListar();

                Gvtiendas.DataSource = listaTienda;
                Gvtiendas.DataBind();
            }


        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ClTiendaE objTienda = new ClTiendaE();
            objTienda.nombreTienda = txtBuscar.Text;
            if (txtBuscar.Text == "")
            {

            }
            else
            {
                ClTiendaL objDatos = new ClTiendaL();
                List<ClTiendaE> listatiendas = objDatos.mtdBuscar(objTienda);

                List<string> buscar = new List<string>();

                for (int i = 0; i < listatiendas.Count; i++)
                {

                    buscar.Add(listatiendas[i].ToString());

                }

                Gvtiendas.DataSource = listatiendas;

                Gvtiendas.DataBind();
            }


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            ClTiendaL objTienda = new ClTiendaL();
            List<ClTiendaE> listaTienda = objTienda.mtdListar();

            Gvtiendas.DataSource = listaTienda;
            Gvtiendas.DataBind();

            txtBuscar.Text = "";
        }

        protected void Gvtiendas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string codigo;
            ClTiendaE objDatos = new ClTiendaE();
            ClTiendaL objTienda = new ClTiendaL();


            if (e.CommandName == "Activar")
            {

                codigo = Gvtiendas.Rows[index].Cells[0].Text;
                objDatos = objTienda.mtdCorreoUsu(codigo);
                string correo = objDatos.email;
                objDatos.estado = "Activa";
                int catAct = objTienda.mtdestado(objDatos, codigo);
                if (catAct >= 1)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Tienda Activa!','Se ha modificado el estado de la tienda, se ha enviado un correo de información','success');", true);
                    mtdCorreo(correo);                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡No hay Cambios!','La tienda no sufrio ninguna actualización','success');", true);
                }


            }
            else if (e.CommandName == "Desactivar")
            {
                codigo = Gvtiendas.Rows[index].Cells[0].Text;
                objDatos = objTienda.mtdCorreoUsu(codigo);
                string correo = objDatos.email;
                objDatos.estado = "Inactiva";
                int catAct = objTienda.mtdestado(objDatos, codigo);
                if (catAct >= 1)
                {
                    mtdCorreo2(correo);
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Tienda Desactivada!','Se ha modificado el estado de la tienda, se ha enviado un correo de información','info');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡No hay Cambios!','La tienda no sufrio ninguna actualización','success');", true);
                }
            }
        }

        public void mtdCorreo(string correo)
        {
            string body = "Bievenido a SkyStore" +
                " Estimado Usuario" +
                " Le informamos que su tienda ya ha sido activada" +
                " Gracias por su atecion quedamos atentos a cualquier inquietud" +
                " Coridal Saludos";

            MailMessage message = new MailMessage();
            message.To.Add(correo);
            message.Subject = "Sky Store";
            message.Body = body;
            message.From = new MailAddress("jscastillo100@misena.edu.co");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("jscastillo100@misena.edu.co", "1029641001jc");
            smtpClient.Send(message);
            

        }

        public void mtdCorreo2(string correo)
        {
            string body = "Bievenido a SkyStore" +
                " Estimado Usuario" +
                " Le informamos que su tienda ha sido desactivada" +
                " Gracias por su atecion quedamos atentos a cualquier inquietud" +
                " Coridal Saludos";

            MailMessage message = new MailMessage();
            message.To.Add(correo);
            message.Subject = "Sky Store";
            message.Body = body;
            message.From = new MailAddress("jscastillo100@misena.edu.co");

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("jscastillo100@misena.edu.co", "1029641001jc");
            smtpClient.Send(message);
            

        }

    }
}
