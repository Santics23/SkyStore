<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="appWebSkyStore.Vista.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://www.paypal.com/sdk/js?client-id=AQ7mBDTa3QjeS0Ss4rOY080s1NjN-XIgG0jQCt9k8rjY5imTQfaHT6kuRRsI8GPfXk1HiD6M1E9UXVHt"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2 class="fw-bold">Carrito de Productos</h2>
        <h2 id="vacio" runat="server" class="text-center">Carrito Vacio!</h2>
        <br />

        <asp:GridView ID="gvCarrito" runat="server" AutoGenerateColumns="False" OnRowCommand="gvCarrito_RowCommand" CssClass="table" ForeColor="Black">
            <Columns>
                <asp:BoundField DataField="idCarrito" HeaderText="Carrito"/>
                <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Precio" HeaderText="Precio" />
                <asp:BoundField DataField="Stock" HeaderText="Stock" />
                <asp:TemplateField HeaderText="Cantidad">
                    <ItemTemplate>
                        <asp:Button ID="btnIncrementar" runat="server" CssClass="btn btn-primary" Text="+" CommandName="Incrementar" CommandArgument='<%# Container.DataItemIndex %>' />
                        <asp:TextBox ID="txtCantidad" runat="server" Text='<%# Bind("cantidad") %>'></asp:TextBox>                        
                        <asp:Button ID="btnDecrementar" runat="server" CssClass="btn btn-danger" Text="-" CommandName="Decrementar" CommandArgument='<%# Container.DataItemIndex %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Opciones">
                    <ItemTemplate>                                                
                        <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-danger" Text="Eliminar" CommandName="Eliminar" CommandArgument='<%# Container.DataItemIndex %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
        <div class="d-flex justify-content-center align-items-center mb-3">
            <asp:Button ID="btnVaciar" runat="server" CssClass="btn btn-warning" Text="Vaciar Carrito" OnClick="btnVaciar_Click"/>
        </div>       
        
        <section id="pagos" runat="server">
            <div id="paypal-button-container"></div>

            <table id="paymentTable" style="display: none;">
                <tr>
                    <th>Nombre del Campo</th>
                    <th>valor</th>
                </tr>
                <tr>
                    <td>Nombre</td>
                    <td id="nameField"></td>
                </tr>
                <tr>
                    <td>Correo Electronico</td>
                    <td>emailField</td>
                </tr>
            </table>

            <div id="successMessage " style="display: none;">
                ¡Pago exitoso!, El pago  ha sido realizado con exito.
            </div>

            <div id="cancelMessage " style="display: none;">
                ¡Pago cancelado!, El pago  ha sido cancelado.
            </div>

            <div id="paymentDetails"></div>
            <script>

                paypal.Buttons({
                    style: {
                        color: 'blue',
                        shape: 'pill',
                        label: 'pay'

                    },
                    craterOrder: function (data, actions) {
                        var total = document.getElementById('valorTotal');
                        return actions.order.create({
                            purchase_unitis: [{
                                amount: {
                                    value: total
                                }
                            }]

                        })

                    },
                    onApprove: function (data, actions) {

                        swal("¡Pago aprobado!", "El pago  ha sido  realizado con exito.", "success");
                        return actions.order.capture().then(function (details) {
                            document.getElementById('paymentDetails').textContent = JSON.stringify(details, null, 2)
                            document.getElementById('namefield').textContent = details.payer.name.given_name + ' ' + details.payer.name.given_name.surname;
                            document.getElementById('emailField').textContent = details.payer.email_adress;
                            document.getElementById('paymentTable').style.display = 'table';
                            document.getElementById('sucessMessage').style.display = 'block';
                            console.log(details);



                        });
                    },
                    OnCancel: function (data) {
                        swal("¡Pago cancelado!", "El pago  ha sido cancelado.", "error");
                        document.getElementById('cancelMessage').style.display = 'block';
                        console.log(data);

                    }

                }).render('#paypal-button-container');
            </script>
        </section>
    </div>
</asp:Content>
