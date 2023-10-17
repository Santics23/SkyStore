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
            if (!IsPostBack)
            {
                ClProductoD objDataCard = new ClProductoD();
                objDataCard.mtdRepeater(cards);

                ClTiendaL objTienda = new ClTiendaL();
                objTienda.mtdRepeaterTienda(marcas);
            }

        }

        protected void agregarAlCarrito_Click(object sender, EventArgs e)
        {

            if (int.Parse(Session["id"].ToString()) == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Primero Inicia Sesión!','Antes de cualquier acción Inicia Sesión','info');", true);
            }
            else
            {
                LinkButton btnAgregar = (LinkButton)sender;
                RepeaterItem item = (RepeaterItem)btnAgregar.NamingContainer;
                // Buscamos el control en ese item 
                ClCarritoE objE = new ClCarritoE();

                Label lblID = (Label)item.FindControl("idProducto");
                objE.idProducto = int.Parse(lblID.Text);
                int idProduct = int.Parse(lblID.Text);

                int idUsuario = int.Parse(Session["id"].ToString());
                objE.idUsuario = int.Parse(Session["id"].ToString());

                ClProductoL objProductL = new ClProductoL();
                List<ClCarritoE> listaCarrito = objProductL.mtdBuscarCarrito(objE);

                int cant = 0;
                for (int i = 0; i < listaCarrito.Count; i++)
                {
                    if (listaCarrito[i].idProducto == idProduct && listaCarrito[i].idUsuario == idUsuario)
                    {
                        objE.idCarrito = listaCarrito[i].idCarrito;
                        objE.cantidad = listaCarrito[i].cantidad + 1;
                    }
                }

                if (listaCarrito.Count > 0)
                {
                    cant = objProductL.mtdRegistrarCarrito2(objE);
                    if (cant > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Producto Añadido al Carrito!','Su Producto se ha vuelto a Añadir con Éxito','success');", true);
                    }
                }
                else
                {
                    objE.cantidad = 1;
                    cant = objProductL.mtdRegistrarCarrito(objE);
                    if (cant > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Producto Añadido al Carrito!','Su Producto ha sido Añadido Éxito','success');", true);
                    }
                }
            }
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