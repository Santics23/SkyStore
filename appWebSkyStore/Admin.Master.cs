﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Session["nombre"].ToString();
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session["id"] = 0;
            Response.Redirect("Home.aspx");
        }
    }
}