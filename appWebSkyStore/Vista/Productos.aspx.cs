using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.FindControl("menu").Visible = false;
            if (!IsPostBack)
            {
                string busqueda = Session["buscar"].ToString();
                ClProductoL objProducts = new ClProductoL();
                objProducts.mtdRepeaterSearch(cards, busqueda);
            }

            if (Session["categs"].ToString() != "")
            {
                ClCategoriaL objProducts = new ClCategoriaL();

                int categ = int.Parse(Session["categs"].ToString());
                string categorias = "";
                if (categ == 1)
                {
                    categorias = "Hombre";
                    cbxHombre.Checked = true;
                    objProducts.mtdRepeaterCateg(cards, categorias);
                    Session["categs"] = "";
                }
                else if (categ == 2)
                {
                    categorias = "Mujer";
                    cbxMujer.Checked = true;
                    objProducts.mtdRepeaterCateg(cards, categorias);
                    Session["categs"] = "";
                }
                else if (categ == 3)
                {
                    categorias = "Infantil";
                    cbxInfantil.Checked = true;
                    objProducts.mtdRepeaterCateg(cards, categorias);
                    Session["categs"] = "";
                }
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            ClSubCategoriaL objFiltros = new ClSubCategoriaL();
            string genero = "";
            if (cbxHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (cbxMujer.Checked)
            {
                genero = "Mujer";
            }
            else if (cbxInfantil.Checked)
            {
                genero = "Infantil";
            }

            string subCategoria = "";

            if (checkZapatillas.Checked)
            {
                subCategoria = "Zapatillas";
            }
            else if (checkTennis.Checked)
            {
                subCategoria = "Tennis";
            }
            else if (checkCamiseta.Checked)
            {
                subCategoria = "Camiseta";
            }
            else if (checkPantalon.Checked)
            {
                subCategoria = "Pantalon";
            }
            else if (checkLicras.Checked)
            {
                subCategoria = "Licras";
            }
            else if (checkBuzo.Checked)
            {
                subCategoria = "Buzos";
            }
            else if (checkSueter.Checked)
            {
                subCategoria = "Sueteres";
            }
            else if (checkSudadera.Checked)
            {
                subCategoria = "Sudaderas";
            }
            else if (checkChaqueta.Checked)
            {
                subCategoria = "Chaquetas";
            }
            else if (checkTop.Checked)
            {
                subCategoria = "Tops";
            }
            else if (checkPantaloneta.Checked)
            {
                subCategoria = "Pantalonetas";
            }
            else if (checkVestidoB.Checked)
            {
                subCategoria = "Vestidos de Baño";
            }
            else if (checkPantaBaño.Checked)
            {
                subCategoria = "Pantalonetas de baño";
            }
            else if (checkVestido.Checked)
            {
                subCategoria = "Vestidos";
            }
            else if (checkBlazer.Checked)
            {
                subCategoria = "Blzaers";
            }
            else if (checkMedias.Checked)
            {
                subCategoria = "Medias";
            }
            else if (checkBoxer.Checked)
            {
                subCategoria = "Boxers";
            }
            else if (checkHoodie.Checked)
            {
                subCategoria = "Hoodies";
            }
            else if (checkJogger.Checked)
            {
                subCategoria = "Joggers";
            }
            else if (checkShort.Checked)
            {
                subCategoria = "Shorts";
            }
            else if (checkRopaI.Checked)
            {
                subCategoria = "Ropa Interior";
            }

            float rangeMin = 0;
            float rangeMax = 0;

            if (checkRange1.Checked)
            {
                rangeMin = 20000;
                rangeMax = 50000;
            }
            else if (checkRange2.Checked)
            {
                rangeMin = 50000;
                rangeMax = 110000;
            }
            else if (checkRange3.Checked)
            {
                rangeMin = 110000;
                rangeMax = 220000;
            }
            else if (checkRange4.Checked)
            {
                rangeMin = 220000;
                rangeMax = 300000;
            }
            else if (checkRange5.Checked)
            {
                rangeMin = 300000;
                rangeMax = 500000;
            }
            else if (checkRange6.Checked)
            {
                rangeMin = 500000;
                rangeMax = 1050000;
            }

            if (cbxAll.Checked)
            {
                cbxHombre.Checked = false;
                cbxMujer.Checked = false;
                cbxInfantil.Checked = false;
                checkZapatillas.Checked = false;
                checkTennis.Checked = false;
                checkCamiseta.Checked = false;
                checkPantalon.Checked = false;
                checkLicras.Checked = false;
                checkBuzo.Checked = false;
                checkSueter.Checked = false;
                checkSudadera.Checked = false;
                checkChaqueta.Checked = false;
                checkTop.Checked = false;
                checkPantaloneta.Checked = false;
                checkVestidoB.Checked = false;
                checkPantaBaño.Checked = false;
                checkVestido.Checked = false;
                checkBlazer.Checked = false;
                checkMedias.Checked = false;
                checkBoxer.Checked = false;
                checkHoodie.Checked = false;
                checkJogger.Checked = false;
                checkShort.Checked = false;
                checkRopaI.Checked = false;
                checkRange1.Checked = false;
                checkRange2.Checked = false;
                checkRange3.Checked = false;
                checkRange4.Checked = false;
                checkRange5.Checked = false;
                checkRange6.Checked = false;
                objFiltros.mtdRepeaterAll(cards);
            }
            else if (genero == "" && subCategoria == "" && rangeMin == 0 && rangeMax == 0)
            {
                objFiltros.mtdRepeaterAll(cards);
            }
            else
            {
                objFiltros.mtdRepeater(cards, genero, subCategoria, rangeMin, rangeMax);
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
    }
}
