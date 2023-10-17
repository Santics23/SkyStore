
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="appWebSkyStore.Vista.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/shop.css" rel="stylesheet" />
    <link href="CSS/home.css" rel="stylesheet" />
    <link href="CSS/owl.carousel.min.css" rel="stylesheet" />
    <link href="CSS/Categorias.css" rel="stylesheet" />
    <style>
        .ocultar {
            display: none;
        }
    </style>
     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <!-- Hero Section Begin -->
        <section class="hero">
            <div class="hero__slider owl-carousel">
                <div class="hero__items set-bg">
                    <div class="container">
                        <div class="row">
                            <div class="col-xl-5 col-lg-7 col-md-8">
                                <div class="hero__text">
                                    <h6>Summer Collection</h6>
                                    <h2>Fall - Winter Collections 2030</h2>
                                    <p>
                                        A specialist label creating luxury essentials. Ethically crafted with an unwavering
                                commitment to exceptional quality.
                                    </p>
                                    <a href="#" class="primary-btn">Shop now <span class="arrow_right"></span></a>
                                    <div class="hero__social">
                                        <a href="#"><i class="fa fa-facebook"></i></a>
                                        <a href="#"><i class="fa fa-twitter"></i></a>
                                        <a href="#"><i class="fa fa-pinterest"></i></a>
                                        <a href="#"><i class="fa fa-instagram"></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="hero__items set-bg">
                    <div class="container">
                        <div class="row">
                            <div class="col-xl-5 col-lg-7 col-md-8">
                                <div class="hero__text">
                                    <h6>Summer Collection</h6>
                                    <h2>Fall - Winter Collections 2030</h2>
                                    <p>
                                        A specialist label creating luxury essentials. Ethically crafted with an unwavering
                                commitment to exceptional quality.
                                    </p>
                                    <a href="#" class="primary-btn">Shop now <span class="arrow_right"></span></a>
                                    <div class="hero__social">
                                        <a href="#"><i class="fa fa-facebook"></i></a>
                                        <a href="#"><i class="fa fa-twitter"></i></a>
                                        <a href="#"><i class="fa fa-pinterest"></i></a>
                                        <a href="#"><i class="fa fa-instagram"></i></a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Hero Section End -->


        <!-- Banner Section Begin -->
        <section id="categorias" class="banner spad">
            <div class="container">
                <div class="pb-3" style="text-align: center; font-weight: 900; font-size: 45px;">
                    Compre Por Categorias
                </div>
                <div class="row">
                    <div class="col-lg-7 offset-lg-4">
                        <div class="banner__item">
                            <div class="banner__item__pic">
                                <img src="imgesCategoria/IMG_1645.jpg" />
                            </div>
                            <div class="banner__item__text">
                                <h2>Hombres</h2>
                                <asp:LinkButton ID="categHombre" CssClass="categs" runat="server" OnClick="categHombre_Click">
                                       Ver más
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-5">
                        <div class="banner__item banner__item--middle">
                            <div class="banner__item__pic">
                                <img src="imgesCategoria/IMG_1641.jpg" />
                            </div>
                            <div class="banner__item__text">
                                <h2>Mujeres</h2>
                                <asp:LinkButton ID="categMujer" CssClass="categs" runat="server" OnClick="categMujer_Click">
                                        Ver más!
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-7">
                        <div class="banner__item banner__item--last">
                            <div class="banner__item__pic">
                                <img src="imgesCategoria/IMG_1646.jpg" />
                            </div>
                            <div class="banner__item__text">
                                <h2>Niños</h2>
                                <asp:LinkButton ID="categChildren" CssClass="categs" runat="server" OnClick="categChildren_Click">
                                       Ver más!
                                </asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Banner Section End -->


        <section id="productos">
            <div class="pb-3" style="text-align: center; font-weight: 900; font-size: 45px;">
                Nuestros Productos
            </div>
            <div class="row pb-3 me-4">
                <asp:Repeater ID="cards" runat="server">
                    <ItemTemplate>
                        <div class="col-3" style="padding-right: 220px;">
                            <div class="d-flex align-items-center justify-content-center mb-4">
                                <div class="col-lg-4 col-md-2 col-sm-12 pb-1">
                                    <div class="index2 card shadow-sm">
                                        <img src="<%# Eval("imagen") %>" id="imgCard" class="card-img-
                                            top" />
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
        </section>

        <section id="SecMarcas">
            <div class="pb-3" style="text-align: center; font-weight: 900; font-size: 45px;">
                Nuestras Tiendas
            </div>
            <div class="slider">
                <div class="slide-track">
                    <asp:Repeater ID="marcas" runat="server">
                        <ItemTemplate>
                            <div class="slide">
                                <img src="<%# Eval("imagen") %>" />
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

    </div>



    <!-- JavaScript Libraries -->
    <script src="../Scripts/owl.carousel.min.js"></script>
    <script src="../Scripts/mainPageP.js"></script>

</asp:Content>
