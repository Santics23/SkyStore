<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegistrarUsuarios.aspx.cs" Inherits="appWebSkyStore.Vista.RegistrarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StylesRegistro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="contact__wrapper shadow-lg mt-n9">
            <div class="row no-gutters">
                <div class="col-lg-5 contact-info__wrapper gradient-brand-color p-5 order-lg-2">
                    <h3 class="color--white fw-bolder mb-5">¡Registrarse!</h3>

                    <figure class="figure position-absolute m-0 opacity-06 z-index-100" style="bottom: 0; right: 10px">
                        <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="444px" height="626px">
                            <defs>
                                <linearGradient id="PSgrad_1" x1="0%" x2="81.915%" y1="57.358%" y2="0%">
                                    <stop offset="0%" stop-color="rgb(255,255,255)" stop-opacity="1"></stop>
                                    <stop offset="100%" stop-color="rgb(0,54,207)" stop-opacity="0"></stop>
                                </linearGradient>

                            </defs>
                            <path fill-rule="evenodd" opacity="0.302" fill="rgb(72, 155, 248)" d="M816.210,-41.714 L968.999,111.158 L-197.210,1277.998 L-349.998,1125.127 L816.210,-41.714 Z"></path>
                            <path fill="url(#PSgrad_1)" d="M816.210,-41.714 L968.999,111.158 L-197.210,1277.998 L-349.998,1125.127 L816.210,-41.714 Z"></path>
                        </svg>
                    </figure>
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
                                <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR" CssClass="btn btn-outline-dark" OnClick="btnRegistrar_Click" />
                            </div>
                            <p class="signup">
                                ¿Quieres Administrar una Tienda?
                                <a rel="noopener noreferrer" href="RegistrarAdminTienda.aspx" class="">Sign up</a>
                            </p>
                        </div>
                    </div>
                </div>
                <!-- End Contact Form Wrapper -->

            </div>
        </div>
    </div>
</asp:Content>
