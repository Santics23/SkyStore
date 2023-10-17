﻿using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class MostrarTeindas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClTiendaL objTienda = new ClTiendaL();
                int id = int.Parse(Session["id"].ToString());
                List<ClTiendaE> listaTienda = objTienda.mtdListarTiendaAdmin(id);

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

            if (e.CommandName == "Productos")
            {
                Response.Redirect("AdministrarProducts.aspx");

            }            
        }
    }
}