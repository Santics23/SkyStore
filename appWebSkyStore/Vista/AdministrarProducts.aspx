<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTienda.Master" AutoEventWireup="true" CodeBehind="AdministrarProducts.aspx.cs" Inherits="appWebSkyStore.Vista.AdministrarProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .row {
            width: 95%;
            font-size: 14px;
            margin-left: 120px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="contDataT" class="container">
        <div class="row flex-shrink-1">
            <table id="DataTableProduct" class="table table-striped">
                <thead>
                    <tr>
                        <th>Codigo</th>
                        <th>Nombre</th>
                        <th>Precio</th>
                        <th>Descripcion</th>
                        <th>Imagen</th>
                        <th>Stock</th>
                        <th>Estado</th>
                        <th>Promocion</th>
                        <th>Descuento</th>
                        <th>Categoria</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody></tbody>
            </table>
        </div>
    </div>


    <div class="modal fade venmodal" id="editarModal" tabindex="-1" role="dialog" aria-labelledby="editarModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="editarModalLabel">Editar Registro</h5>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>

                <div class="modal-body">
                    <asp:TextBox ID="txtCodigo" runat="server" placeholder="Codigo" class="form-control mb-3 txt-codigo"></asp:TextBox>

                    <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control mb-3 txt-nombre h-100"></asp:TextBox>

                    <asp:TextBox ID="txtPrecio" runat="server" placeholder="Precio" class="form-control mb-3 txt-precio"></asp:TextBox>

                    <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" CssClass="form-control mb-3 txt-descripcion"></asp:TextBox>

                    <asp:TextBox ID="txtStock" runat="server" placeholder="Stock" class="form-control mb-3 txt-stock"></asp:TextBox>

                    <asp:TextBox ID="txtEstado" runat="server" placeholder="Estado" class="form-control mb-3 txt-estado"></asp:TextBox>

                    <asp:TextBox ID="txtPromoción" runat="server" placeholder="Estado" class="form-control mb-3 txt-promo"></asp:TextBox>

                    <asp:TextBox ID="txtDescuento" runat="server" placeholder="Estado" class="form-control mb-3 txt-desc"></asp:TextBox>

                    <select id="sltSubCategoria" runat="server" class="js-example-basic-multiple form-select mb-3 txt-subcateg" name="states">
                    </select>
                </div>

                <div class="modal-footer">
                    <%--<asp:Button id="btnActualizar" class="btn btn-primary" runat="server" Text="Actualizar" />--%>
                    <button id="btnActualizar" class="btn btn-primary" type="button">Actualizar</button>
                </div>
            </div>
        </div>
    </div>

    <%--Scrpts--%>
</asp:Content>
