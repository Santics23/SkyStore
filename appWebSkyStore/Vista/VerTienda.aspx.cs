using appWebSkyStore.Logica;
using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class VerTienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("menu").Visible = false;
            ClTiendaL objTienda = new ClTiendaL();
            objTienda.mtdRepeaterT(marcas);
        }
    }
}