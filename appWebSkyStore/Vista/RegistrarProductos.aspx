<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTienda.Master" AutoEventWireup="true" CodeBehind="RegistrarProductos.aspx.cs" Inherits="appWebSkyStore.Vista.RegistrarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/stylesRegistroProduct.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.13/css/select2.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="row justify-content-center">
            <div class="col-lg-6 col-md-8 login-box">
                <div class="col-lg-12 login-title mt-5">
                    Registrar Productos
                </div>
                <div class="col-lg-12 login-form">
                    <div>
                        <div class="form-group">
                            <label class="form-control-label">Codigo:</label>
                            <asp:TextBox ID="txtCodigo" runat="server" placeholder="Codigo" class="form-control"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Nombre:</label>
                            <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Precio:</label>
                            <asp:TextBox ID="txtPrecio" runat="server" placeholder="Precio" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Descripción:</label>
                            <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label for="fluTienda" class="form-control-label">Seleccione una imagen para sus productos:</label>
                            <asp:FileUpload ID="flpImagen" runat="server" class="form-control" />
                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Stock:</label>
                            <asp:TextBox ID="txtStock" runat="server" placeholder="Stock" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Estado:</label>
                            <asp:TextBox ID="txtEstado" runat="server" placeholder="Estado" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Promoción:</label>
                            <asp:TextBox ID="txtPromocion" runat="server" placeholder="Promoción" class="form-control" AutoPostBack="true" OnTextChanged="txtPromocion_TextChanged"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="lblDescuento" runat="server" class="form-control-label">Descuento:</asp:Label>
                            <asp:TextBox ID="txtDescuento" runat="server" placeholder="Descuento" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label class="form-control-label">Categoria:</label>
                            <select id="sltSubCategoria" runat="server" class="js-example-basic-multiple form-select" name="states">
                            </select>
                        </div>

                        <div class="col-12 login-btm login-button justify-content-center d-flex">
                            <asp:Button ID="btnRegistar" runat="server" Text="REGISTRAR" CssClass="btn btn-outline-light" OnClick="btnRegistar_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

   <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.13/js/select2.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.js-example-basic-multiple').select2();
        });
    </script>
</asp:Content>
