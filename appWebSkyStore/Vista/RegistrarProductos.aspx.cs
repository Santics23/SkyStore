using appWebSkyStore.Datos;
using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class RegistrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ComboBoxCategoria();
                lblDescuento.Visible = false;
                txtDescuento.Visible = false;
            }


        }

        protected void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtPrecio.Text != "" && txtDescripcion.Text != "" && txtStock.Text != "" && txtEstado.Text != "" || txtPromocion.Text != "")
            {
                if (flpImagen.HasFile)
                {
                    string imagen = txtCodigo.Text + ".png";
                    string rutaImg = Server.MapPath("~/Vista/ImagenProducto/" + imagen);
                    flpImagen.SaveAs(rutaImg);
                    string codigo = txtCodigo.Text;
                    ClProductoL objProducto = new ClProductoL();
                    //int contador = objProducto.mtdCodigo(codigo);
                    ClProductoE objDatosProductos = new ClProductoE();

                    objDatosProductos.Codigo = txtCodigo.Text;
                    objDatosProductos.Nombre = txtNombre.Text;
                    objDatosProductos.Precio = float.Parse(txtPrecio.Text);
                    objDatosProductos.Descripcion = txtDescripcion.Text;
                    objDatosProductos.Imagen = "ImagenProducto/" + imagen;
                    objDatosProductos.Stock = int.Parse(txtStock.Text);
                    objDatosProductos.Estado = txtEstado.Text;
                    objDatosProductos.Promocion = txtPromocion.Text;
                    if (txtDescuento.Text == "")
                    {
                        objDatosProductos.Descuento = 0;
                    }
                    else
                    {
                        objDatosProductos.Descuento = float.Parse(txtDescuento.Text);
                    }

                    objDatosProductos.idSubCategoria = int.Parse(sltSubCategoria.SelectedIndex.ToString());


                    ClProductoD objProductoD = new ClProductoD();
                    int resultado = objProductoD.MtdRegistrar(objDatosProductos);

                    if (resultado == 1)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('Producto Registrado','El Producto se Ha Registrado','success');", true);
                        limpiar();
                    }

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('No ha Ingresado una Imagen','Ingrese una imagen para registrar su producto','info');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "SweetAlert", "sweetAlert2('¡Hay Algunos Datos Vacios!','Porfavor rellene Todos los Datos','info');", true);
            }

        }
        public void ComboBoxCategoria()
        {

            ClSubCategoriaL objDatos = new ClSubCategoriaL();
            List<ClSubCategoriaE> listaSubCategoria = new List<ClSubCategoriaE>();
            listaSubCategoria = objDatos.mtdListarSub();


            sltSubCategoria.DataSource = listaSubCategoria;
            sltSubCategoria.DataTextField = "subCategoria";
            sltSubCategoria.DataValueField = "idSubCategoria";

            sltSubCategoria.DataBind();

            sltSubCategoria.Items.Insert(0, new ListItem("Seleccione:", "0"));



        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            flpImagen = null;
            txtStock.Text = "";
            txtEstado.Text = "";
            txtPromocion.Text = "";
            txtDescuento.Text = "";
            sltSubCategoria.SelectedIndex = 0;
        }

        protected void txtPromocion_TextChanged(object sender, EventArgs e)
        {
            if (txtPromocion.Text.Equals("Si") || txtPromocion.Text.Equals("si") || txtPromocion.Text.Equals("sI") || txtPromocion.Text.Equals("SI"))
            {
                lblDescuento.Visible = true;
                txtDescuento.Visible = true;
            }
        }
    }
}