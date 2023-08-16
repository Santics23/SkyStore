<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VerTienda.aspx.cs" Inherits="appWebSkyStore.Vista.VerTienda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/verTienda.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="pb-3" style="text-align: center; font-weight: 900; font-size: 45px;">
            Compra Por Tiendas
        </div>
        <div class="wrap">
            <asp:Repeater ID="marcas" runat="server">
                <ItemTemplate>
                    <div class="box mt-2 me-4">
                        <div class="box-top">
                            <img class="box-image" src="<%# Eval("imagen") %>">
                            <div class="title-flex">
                                <h3 class="box-title"><%# Eval("nombreTienda")  %></h3>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
