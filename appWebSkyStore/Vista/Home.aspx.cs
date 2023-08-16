using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ClProductoD objDataCard = new ClProductoD();
            objDataCard.mtdRepeater(cards);

            ClTiendaL objTienda = new ClTiendaL();
            objTienda.mtdRepeaterTienda(marcas);
        }

        protected void categMujer_Click(object sender, EventArgs e)
        {
            Session["categs"] = 2;
            Response.Redirect("Productos.aspx");
        }

        protected void categHombre_Click(object sender, EventArgs e)
        {
            Session["categs"] = 1;
            Response.Redirect("Productos.aspx");
        }

        protected void categChildren_Click(object sender, EventArgs e)
        {
            Session["categs"] = 3;
            Response.Redirect("Productos.aspx");            
        }
    }
}