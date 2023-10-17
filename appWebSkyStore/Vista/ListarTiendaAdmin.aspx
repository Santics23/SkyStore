<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ListarTiendaAdmin.aspx.cs" Inherits="appWebSkyStore.Vista.ListarTiendaAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/barra.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:TextBox ID="txtBuscar" runat="server" class="form-control"></asp:TextBox><br />

            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" class="btn btn-outline-primary" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" class="btn btn-outline-info" />

            <br />
            <br />

            <asp:GridView ID="Gvtiendas" runat="server" AutoGenerateColumns="false" OnRowCommand="Gvtiendas_RowCommand" CssClass="table" ForeColor="Black">


                <Columns>
                    <asp:BoundField DataField="codigoTienda" HeaderText="Codigo" />
                    <asp:BoundField DataField="nombreTienda" HeaderText="Nombre" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="direccion" HeaderText="Direccion" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnActivar" runat="server" Text="Activar" CommandName="Activar" CommandArgument='<%# Container.DataItemIndex %>' class="btn btn-success" />
                            <asp:Button ID="btnInactivar" runat="server" Text="Desactivar" CommandName="Desactivar" CommandArgument='<%# Container.DataItemIndex %>' class="btn btn-warning" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

            </asp:GridView>




        </ContentTemplate>

    </asp:UpdatePanel>


</asp:Content>
