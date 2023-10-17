using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class Carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.Parse(Session["id"].ToString()) == 0)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "MostrarSweetAlert();", true);
                }
                else
                {
                    llenarGrid();
                }

            }
        }
        
        private void llenarGrid()
        {
            ClProductoL objProductoL = new ClProductoL();
            int idUsuario = int.Parse(Session["id"].ToString());
            List<ClCarritoE> listaCarrito = objProductoL.mtdCarrito(idUsuario);
            if (listaCarrito.Count > 0)
            {
                gvCarrito.DataSource = listaCarrito;
                gvCarrito.DataBind();
                vacio.Visible = false;
                pagos.Visible = true;
            }
            else
            {
               btnVaciar.Visible = false;
               vacio.Visible = true;
               pagos.Visible = false;
            }

        }

        protected void gvCarrito_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            string codigo;
            ClCarritoE objCarrito = new ClCarritoE();
            ClProductoL objProductoL = new ClProductoL();

            if (e.CommandName == "Incrementar")
            {
                codigo = gvCarrito.Rows[index].Cells[0].Text;
                TextBox txtCantidad = (TextBox)gvCarrito.Rows[index].Cells[1].FindControl("txtCantidad");                ;
                int cantidad = int.Parse(txtCantidad.Text);
                cantidad++;
                txtCantidad.Text = cantidad.ToString();

                objCarrito.cantidad = cantidad;
                int idCar = int.Parse(codigo);
                objCarrito.idCarrito = idCar;
                int cant = objProductoL.mtdRegistrarCarrito2(objCarrito);


            }
            else if (e.CommandName == "Decrementar")
            {
                codigo = gvCarrito.Rows[index].Cells[0].Text;
                TextBox txtCantidad = (TextBox)gvCarrito.Rows[index].Cells[1].FindControl("txtCantidad"); ;
                int cantidad = int.Parse(txtCantidad.Text);

                txtCantidad.Text = cantidad.ToString();
                if (cantidad > 0)
                {
                    cantidad--;
                    txtCantidad.Text = cantidad.ToString();
                    objCarrito.cantidad = cantidad;
                    int idCar = int.Parse(codigo);
                    objCarrito.idCarrito = idCar;
                    int cant = objProductoL.mtdRegistrarCarrito2(objCarrito);
                }
                    
            }
            else if (e.CommandName == "Eliminar")
            {
                codigo = gvCarrito.Rows[index].Cells[0].Text;
                int idCar = int.Parse(codigo);
                objCarrito.idCarrito = idCar;
                int cant = objProductoL.mtdEliminarCarrito(objCarrito);
                llenarGrid();
            }
        }

        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            ClCarritoE objCarrito = new ClCarritoE();
            ClProductoL objProductoL = new ClProductoL();
            int idUsuario = int.Parse(Session["id"].ToString());
            objCarrito.idUsuario = idUsuario;
            int cant = objProductoL.mtdVaciarCarrito(objCarrito);
            llenarGrid();
        }
    }
}