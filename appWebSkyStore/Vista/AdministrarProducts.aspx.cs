using appWebSkyStore.Entidades;
using appWebSkyStore.Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWebSkyStore.Vista
{
    public partial class AdministrarProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClProductoL objProductoL = new ClProductoL();
                List<ClProductoE> list = objProductoL.mtdListar();
                string Json = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
                ClientScript.RegisterStartupScript(GetType(), "JsonScript", $"var jsonData ={Json};", true);


                ClSubCategoriaL objDatos = new ClSubCategoriaL();
                List<ClSubCategoriaE> listaSubCategoria = new List<ClSubCategoriaE>();
                listaSubCategoria = objDatos.mtdListarSub();

                sltSubCategoria.DataSource = listaSubCategoria;
                sltSubCategoria.DataTextField = "subCategoria";
                sltSubCategoria.DataValueField = "idSubCategoria";

                sltSubCategoria.DataBind();

                sltSubCategoria.Items.Insert(0, new ListItem("Seleccione:", "0"));
            }
        }

        [WebMethod]
        public static List<ClProductoE> mtdCargarDatos(int idProducto)
        {
            ClProductoL objProductoL = new ClProductoL();
            List<ClProductoE> producto = objProductoL.mtdIdPersonal(idProducto);
            if (producto.Count > 0)
            {
                return producto;
            }


            return null;
        }

        [WebMethod]
        public static string mtdActualizarProducto(object data)
        {
            ClProductoL objProductoL = new ClProductoL();
            ClProductoE objActualizarProducto = new ClProductoE();

            var datos = data as IDictionary<string, object>;


            objActualizarProducto.idProducto = int.Parse(datos["idProducto"].ToString());
            objActualizarProducto.Codigo = datos["Codigo"].ToString();
            objActualizarProducto.Nombre = datos["Nombre"].ToString();
            objActualizarProducto.Precio = float.Parse(datos["Precio"].ToString());
            objActualizarProducto.Descripcion = datos["Descripcion"].ToString();
            objActualizarProducto.Stock = int.Parse(datos["Stock"].ToString());
            objActualizarProducto.Estado = datos["Estado"].ToString();
            objActualizarProducto.Promocion = datos["Promocion"].ToString();
            objActualizarProducto.Descuento = float.Parse(datos["Descuento"].ToString());
            objActualizarProducto.idSubCategoria = int.Parse(datos["idSubCategoria"].ToString());

            int resultado = objProductoL.mtdActualizacion(objActualizarProducto);

            return "success"; // Devuelve una respuesta al cliente

        }

        [WebMethod]
        public static List<ClProductoE> mtdListar()
        {
            ClProductoL objProductoL = new ClProductoL();
            List<ClProductoE> listaProducto = objProductoL.mtdListar();

            return listaProducto;
        }

        [WebMethod]
        public static string mtdEliminar(object formData)
        {
            ClProductoL objProductoL = new ClProductoL();
            ClProductoE objEliminarPersonal = new ClProductoE();
            var data = formData as IDictionary<string, object>;
            objEliminarPersonal.idProducto = int.Parse(data["idProducto"].ToString());

            int resultado = objProductoL.mtdEliminar(objEliminarPersonal);

            return string.Empty;
        }
    }
}