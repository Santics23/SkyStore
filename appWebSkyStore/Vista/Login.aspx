<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="appWebSkyStore.Vista.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-container">
        <p class="title">Ingresar</p>
        <div class="form">
            <div class="input-group">
                <label for="username">Email</label>
                <asp:TextBox ID="txtUsuario" name="username" runat="server" class="input" placeholder="Email" TextMode="Email" required=""></asp:TextBox>
            </div>
            <div class="input-group">
                <label for="password">Contraseña</label>
                <asp:TextBox ID="txtClave" runat="server" name="password" class="input" placeholder="**********" TextMode="Password" required=""></asp:TextBox>
            </div>
            <div class="pt-5">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" CssClass="sign" />
            </div>
        </div>

        <p class="signup pt-2">
            ¿Aún No tiene una Cuenta?
		<a rel="noopener noreferrer" href="RegistrarUsuarios.aspx" class="">Registrate!</a>
        </p>
    </div>
</asp:Content>
