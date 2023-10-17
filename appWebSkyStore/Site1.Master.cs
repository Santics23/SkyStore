using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using appWebSkyStore.Vista;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.Parse(Session["id"].ToString()) == 0)
            {
                Logsign.Visible = true;
                options.Visible = false;
            }
            else
            {
                Logsign.Visible = false;
                options.Visible = true;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Session["buscar"] = busqueda;
            Response.Redirect("Productos.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["id"] = 0;
            Response.Redirect("Home.aspx");
        }

        protected void btnOpciones_Click(object sender, EventArgs e)
        {
            if (int.Parse(Session["rol"].ToString()) == 1)
            {
                Response.Redirect("~/Vista/DatosAdmin.aspx");
            }
            else if (int.Parse(Session["rol"].ToString()) == 2)
            {
                Response.Redirect("~/Vista/DatosAdminT.aspx");
            }
            else if (int.Parse(Session["rol"].ToString()) == 3)
            {
                Response.Redirect("~/Vista/DatosCliente.aspx");
            }
        }
    }
    
}

