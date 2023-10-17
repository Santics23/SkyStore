<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="DatosCliente.aspx.cs" Inherits="appWebSkyStore.Vista.DatosCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StylesRegistroEdit.css" rel="stylesheet" />
    <link href="SweetAlert/Css/sweetalert.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="SweetAlert/Script/sweetalert-dev.js"></script>
    <script src="SweetAlert/Script/sweetalert.min.js"></script>
    <script src="../Scripts/sweetAlert.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="contact__wrapper shadow-lg mt-n9">
            <div class="row no-gutters">
                <div class="col-lg-5 contact-info__wrapper gradient-brand-color p-5 order-lg-2">
                </div>

                <div class="col-lg-7 contact-form__wrapper p-5 order-lg-1">
                    <div action="#" class="contact-form form-validate" novalidate="novalidate">
                        <div class="row">
                            <div class="col-sm-6 mb-3">
                                <div class="form-group">
                                    <label class="required-field" for="document">Documento</label>
                                    <asp:TextBox ID="txtDocumento" name="document" placeholder="Documento" class="form-control" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-6 mb-3">
                                <div class="form-group">
                                    <label for="username">Nombre</label>
                                    <asp:TextBox ID="txtNombre" name="username" placeholder="Nombre" class="form-control" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-6 mb-3">
                                <div class="form-group">
                                    <label for="username">Apellido</label>
                                    <asp:TextBox ID="txtApellido" name="LastName" placeholder="Apellido" class="form-control" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-6 mb-3">
                                <div class="form-group">
                                    <label for="phone">Telefono</label>
                                    <asp:TextBox ID="txtTelefono" name="phone" placeholder="Telefono" class="form-control" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 mb-3">
                                <div class="form-group">
                                    <label for="email">Email</label>
                                    <asp:TextBox ID="txtEmail" placeholder="Email" name="email" type="email" class="form-control" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 mb-3">
                                <div class="form-group">
                                    <label for="password">Contraseña</label>
                                    <asp:TextBox ID="txtClave" placeholder="********" name="password" class="form-control" runat="server" required=""></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-sm-12 mb-3">
                                <asp:Button ID="btnEditar" runat="server" Text="EDITAR" CssClass="btn btn-outline-dark" OnClick="btnEditar_Click" />
                            </div>

                        </div>
                    </div>
                </div>
                <!-- End Contact Form Wrapper -->

            </div>
        </div>
    </div>

    <%--Scrpts--%>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
    <script src="SweetAlert/Script/sweetalert-dev.js"></script>
    <script src="SweetAlert/Script/sweetalert.min.js"></script>
    <script src="../Scripts/sweetAlert.js"></script>
</asp:Content>
