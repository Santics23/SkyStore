<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="appWebSkyStore.Vista.Productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/shop.css" rel="stylesheet" />
    <script src="../Scripts/jquery.nicescroll.js"></script>
    <script src="../Scripts/jquery.nicescroll.min.js"></script>
    <script src="../Scripts/shop.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.nicescroll/3.7.6/jquery.nicescroll.min.js" integrity="sha512-zMfrMAZYAlNClPKjN+JMuslK/B6sPM09BGvrWlW+cymmPmsUT1xJF3P4kxI3lOh9zypakSgWaTpY6vDJY/3Dig==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <link href="CSS/popup.css" rel="stylesheet" />
    <link href="CSS/slicknav.min.css" rel="stylesheet" />
    <style>
        .textfil {
            text-align: center;
        }

        .ocultar {
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Shop Section Begin -->

    <div class="container">
        <div class="row">
            <div class="col-lg-3">
                <div class="shop__sidebar">
                    <div class="textfil mb-3">
                        <label class="h4 fw-bolder">Filtros</label>
                    </div>
                    <div class="shop__sidebar__accordion">
                        <div class="accordion" id="accordionExample">
                            <div class="index card">
                                <div class="card-heading">
                                    <a data-toggle="collapse" data-target="#collapseOne">Géneros</a>
                                </div>
                                <div id="collapseOne" class="collapse show" data-parent="#accordionExample">
                                    <div class="card-body2">
                                        <div class="shop__sidebar__categories">
                                            <ul class="nice-scroll">
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="cbxHombre" GroupName="checkCategs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label ID="lblHombre" class="form-check-label" runat="server" for="cbxHombre">Hombre</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="cbxMujer" GroupName="checkCategs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label ID="lblMujer" class="form-check-label" runat="server" for="cbxMujer">Mujer</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="cbxInfantil" GroupName="checkCategs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label ID="lblInfantil" class="form-check-label" runat="server" for="cbxInfantil">Niños</asp:Label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="index card">
                                <div class="card-heading">
                                    <a data-toggle="collapse" data-target="#collapseTwo">Categorias</a>
                                </div>
                                <div id="collapseTwo" class="collapse show" data-parent="#accordionExample">
                                    <div class="card-body2">
                                        <div class="shop__sidebar__categories1">
                                            <ul class="nice-scroll">
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkZapatillas" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkZapatillas">Zapatillas</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkTennis" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkTennis">Tennis</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkCamiseta" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkCamiseta">Camisetas</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkPantalon" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkPantalon">Pantalones</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkLicras" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkLicras">Licras</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkBuzo" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkBuzo">Buzos</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkSueter" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkSueter">Sueteres</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkSudadera" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkSudadera">Sudaderas</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkChaqueta" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkChaqueta">Chaquetas</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkTop" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkTop">Tops</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkPantaloneta" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="flexCheckDefault">Pantalonetas</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkVestidoB" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkVestidoB">Vestidos de Baño</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkPantaBaño" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkPantaBaño">Pantalonetas de Baño</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkVestido" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkVestido">Vestidos</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkBlazer" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkBlazer">Blazers</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkMedias" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkMedias">Medias</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkBoxer" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkBoxer">Boxers</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkHoodie" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkHoodie">Hoodies</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkJogger" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkJogger">Joggers</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkShort" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkShort">Shorts</asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRopaI" GroupName="checkSubs" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRopaI">Ropa Interior</asp:Label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="index card">
                                <div class="card-heading">
                                    <a data-toggle="collapse" data-target="#collapseFour">Filtro de Precios</a>
                                </div>
                                <div id="collapseFour" class="collapse show" data-parent="#accordionExample">
                                    <div class="card-body2">
                                        <div class="shop__sidebar__price">
                                            <ul>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRange1" GroupName="checkrange" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRange1">$ 20.000 - $ 50.000 </asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRange2" GroupName="checkrange" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRange2">$ 50.000 - $ 110.000 </asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRange3" GroupName="checkrange" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRange3">$ 110.000 - $ 220.000 </asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRange4" GroupName="checkrange" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRange4">$ 220.000 - $ 300.000 </asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRange5" GroupName="checkrange" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRange5">$ 300.000 - $ 500.000 </asp:Label>
                                                </li>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="checkRange6" GroupName="checkrange" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label class="form-check-label" runat="server" for="checkRange6">$ 500.000 - $ 1.050.000 </asp:Label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="index card">
                                <div class="card-heading">
                                    <a data-toggle="collapse" data-target="#collapseFive">Ver todo</a>
                                </div>
                                <div id="collapseFive" class="collapse show" data-parent="#accordionExample">
                                    <div class="card-body2">
                                        <div class="shop__sidebar__price">
                                            <ul>
                                                <li class="form-check ps-4">
                                                    <asp:RadioButton ID="cbxAll" runat="server" class="form-check-input pt-0 mt-0" />
                                                    <asp:Label ID="lblAll" class="form-check-label" runat="server" for="cbxAll">Mostrar Todo</asp:Label>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div>
                                <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" class="btn btn-outline-dark mt-2 ms-5" OnClick="btnFiltrar_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-lg-9 col-md-12">
                <div class="row pb-3">
                    <asp:Repeater ID="cards" runat="server">
                        <ItemTemplate>
                            <div class="col-3" style="padding-right: 250px;">
                                <div class="d-flex align-items-center justify-content-center mb-4">
                                    <div class="col-lg-4 col-md-2 col-sm-12 pb-1">
                                        <div class="index2 card shadow-sm">
                                            <img src="<%# Eval("imagen") %>" id="imgCard" class="card-img-top" />
                                            <div id="label-top" class="shadow-sm"><%# Eval("subCategoria")  %></div>
                                            <div class="card-body">
                                                <h5 class="card-title mb-0"><%# Eval("nombreProducto")  %></h5>
                                                <div class="clearfix">
                                                    <span class="float-start badge rounded-pill bg-black"><%# Eval("precio")  %></span>
                                                    <span class="float-end"><a href="#" class="small text-muted"><%# Eval("descripcion")  %></a></span>
                                                    <asp:Label ID="idProducto" runat="server" class="ocultar" Text='<%# Eval("idProducto") %>'></asp:Label>
                                                </div>
                                                <div class="text-center my-4">
                                                    <div class="button">
                                                        <div class="button-wrapper">
                                                            <div class="text" style="font-size: 11px;">Añadir al Carrito +</div>
                                                            <asp:LinkButton runat="server" class="icon" OnClick="agregarAlCarrito_Click">
                                            <i class="fa fa-cart-shopping fa-lg"></i>
                                                            </asp:LinkButton>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>

    <!--JavaScript-->
    <script>
        // Obtén una lista de todos los radio buttons
        const radioButtons = document.querySelectorAll('input[type="radio"]');

        // Agrega un evento de doble clic a cada radio button
        radioButtons.forEach(radioButton => {
            let clickCount = 0;
            radioButton.addEventListener('click', () => {
                clickCount++;
                // Si el contador llega a 2 (doble clic), desmarca el radio button
                if (clickCount === 2) {
                    radioButton.checked = false;
                    clickCount = 0;
                }
            });
        });
    </script>

    <script src="../Scripts/shop.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery.nicescroll/3.7.6/jquery.nicescroll.min.js" integrity="sha512-zMfrMAZYAlNClPKjN+JMuslK/B6sPM09BGvrWlW+cymmPmsUT1xJF3P4kxI3lOh9zypakSgWaTpY6vDJY/3Dig==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="../Scripts/popup.min.js"></script>
    <script src="../Scripts/slicknav.js"></script>
</asp:Content>
