<%@ Page Title="" Language="C#" MasterPageFile="~/AdminTienda.Master" AutoEventWireup="true" CodeBehind="RegistrarTienda.aspx.cs" Inherits="appWebSkyStore.Vista.RegistrarTienda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Estilos para el campo de carga de archivos */
        .custom-file-input {
            visibility: hidden;
            width: 0;
        }

        .custom-file-label {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
            display: inline-block;
            position: relative;
            overflow: hidden;
        }

            .custom-file-label:hover {
                background-color: #0056b3;
            }

        /* Cambia el estilo cuando se selecciona un archivo */
        .custom-file-input:focus ~ .custom-file-label {
            border-color: #80bdff;
            box-shadow: 0 0 0 0.2rem rgba(0, 123, 255, 0.25);
        }

        /* Estilos cuando hay un archivo cargado */
        .custom-file-input:valid ~ .custom-file-label {
            background-color: #28a745;
        }

        /* Añade un margen derecho al botón de carga para separarlo del campo de texto */
        .custom-file-input ~ .custom-file-label {
            margin-right: 5px;
        }
    </style>
    <link href="CSS/RegistroTienda.css" rel="stylesheet" />
    <link href="../Styles/sweetalert.css" rel="stylesheet" />
    <script src="../Scripts/sweetalert.min.js"></script>
    <script src="../Scripts/sweetalert-dev.js"></script>
    <script src="../Scripts/sweetAlerts.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div>
        <div class="container">
            <header>
                <h1></h1>
            </header>
            <h1 class="text-center">Registro de Tienda</h1>

            <asp:Panel ID="formularioPanel" runat="server">

                <label class="text-bg-info">
                    <span class="label-text">Codigo</span>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                </label>


                <label class="text-bg-info">
                    <span class="label-text">Nombre de la Tienda</span>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </label>


                <label class="text-bg-info">
                    <span class="label-text">Descripcion de la tienda</span>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                </label>


                <asp:FileUpload ID="fileUpload" type="file" class="custom-file-input" runat="server" />
                <label for="fileUpload" class="custom-file-label">Seleccionar archivo</label>

                <br />
                <br />


                <label class="text-bg-info">
                    <span class="label-text">Direccion</span>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </label>

                <div class="text-center">
                    <asp:Button Class="btn-dark" ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                </div>

                <br />

                <div>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Términos y Condiciones.pdf" Target="_blank">Terminos y Condiciones</asp:HyperLink>
                </div>
            </asp:Panel>

            <asp:Panel ID="Panel1" runat="server">

                <h8 class="text-xxl-start">Por favor digite su correo electronico para hacerle una solicitud de el RUT y la CC</h8>
                <br />
                <br />
                <label class="text-bg-info">
                    <span class="label-text">Correo</span>
                    <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
                </label>

                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" Class="btn-buscar" OnClick="btnEnviar_Click" />

            </asp:Panel>


        </div>

    </div>


    <script>
        const fileInput = document.getElementById("fileUpload");
        const fileLabel = document.querySelector(".custom-file-label");

        fileInput.addEventListener("change", function () {
            if (this.files.length > 0) {
                fileLabel.textContent = this.files[0].name;
            } else {
                fileLabel.textContent = "Seleccionar archivo";
            }
        });
        </script>
</asp:Content>
