<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarAdminTienda.aspx.cs" Inherits="appWebSkyStore.Vista.RegistrarAdminTienda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="CSS/RegistroAdminTienda.css" rel="stylesheet" />
    <script src="../Scripts/sweetAlert.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11.7.23/dist/sweetalert2.min.css"/>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11.7.23/dist/sweetalert2.all.min.js"></script>
    <script src="../Scripts/sweetAlert.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <header>
                <h1></h1>
            </header>
            <h1 class="text-center">Registrar Administrador de Tienda</h1>

            <label class="col-one-half">
                <span class="label-text">Documento</span>
                <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
            </label>

            <label class="col-one-half">
                <span class="label-text">Nombre</span>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </label>

            <label class="col-one-half">
                <span class="label-text">Apellido</span>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </label>


            <label class="col-one-half">
                <span class="label-text">Telefono</span>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </label>

            <label>
                <span class="label-text">Email</span>
                <span class="glyphicon glyphicon-eye-close"></span>
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
            </label>

            <label class="password">
                <span class="label-text">Password</span>
                <button class="toggle-visibility" title="toggle password visibility" tabindex="-1">
                    <span class="glyphicon glyphicon-eye-close"></span>
                </button>
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            </label>

            <div class="text-center">
                <asp:Button Class="btn-dark" ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
            </div>
        </div>
    </form>

    <%-- Scripts--%>

    <script src="../Scripts/sweetAlert.js"></script>
    <script src="SweetAlert/Script/sweetalert-dev.js"></script>
    <script src="SweetAlert/Script/sweetalert.min.js"></script>
    <link href="SweetAlert/Css/sweetalert.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</body>
</html>
