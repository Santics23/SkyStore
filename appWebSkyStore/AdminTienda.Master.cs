using appWebSkyStore.Datos;
using appWebSkyStore.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore
{
    public partial class AdminTienda : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Session["nombre"].ToString();
        }
    }
}