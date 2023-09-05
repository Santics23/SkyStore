<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTienda.Master" AutoEventWireup="true" CodeBehind="RegistrarTienda.aspx.cs" Inherits="appWebSkyStore.Vista.RegistrarTienda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StylesRegistroRegisT.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel runat="server" ID="formularioPanel">
        <div class="container" style="padding: 2rem;">
            <div class="contact__wrapper shadow-lg mt-n9">
                <div class="row no-gutters">
                    <div class="col-lg-5 contact-info__wrapper gradient-brand-color p-5 order-lg-2">
                    </div>

                    <div class="col-lg-7 contact-form__wrapper p-5 order-lg-1">
                        <div action="#" class="contact-form form-validate" novalidate="novalidate">
                            <div class="row">
                                <div class="col-sm-6 mb-3">
                                    <div class="form-group">
                                        <label class="required-field" for="Codigo">Codigo:</label>
                                        <asp:TextBox ID="txtCodigo" name="Codigo" placeholder="Codigo" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-sm-6 mb-3">
                                    <div class="form-group">
                                        <label for="username">Nombre</label>
                                        <asp:TextBox ID="txtNombre" name="username" placeholder="Nombre" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-sm-6 mb-3">
                                    <div class="form-group">
                                        <label for="Descripcion">Descripción:</label>
                                        <asp:TextBox ID="txtDescripcion" name="Descripcion" placeholder="Descripcion" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-sm-6 mb-3">
                                    <div class="form-group">
                                        <label for="Direccion">Dirección</label>
                                        <asp:TextBox ID="txtDireccion" name="Direccion" placeholder="Direccion" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>

                                <div class="col-sm-6 mb-3">
                                    <div class="form-group">
                                        <label for="fileUpload" class="">Seleccionar archivo</label>
                                        <asp:FileUpload ID="fileUpload" type="file" class="form-control" runat="server" />
                                    </div>
                                </div>

                                <div class="col-sm-12 mb-3">
                                    <asp:Button Class="btn btn-dark" ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                                </div>
                                <div>
                                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Términos y Condiciones.pdf" Target="_blank">Terminos y Condiciones</asp:HyperLink>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Contact Form Wrapper -->

                </div>
            </div>
        </div>
    </asp:Panel>


    <asp:Panel ID="Panel1" runat="server">
        <div style="border: solid; border-radius:5px;">
            <div style="padding:123px">
                <h8 class="text-xxl-start">Por favor digite su correo electronico para hacerle una solicitud de el RUT y la CC</h8>
                <br />
                <br />
                <div class="input-group">
                    <span class="input-group-text">Correo</span>
                    <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server" aria-describedby="btnEnviar"></asp:TextBox>
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" Class="btn btn-outline-dark" OnClick="btnEnviar_Click" />
                </div>                
            </div>
        </div>
    </asp:Panel>


</asp:Content>
