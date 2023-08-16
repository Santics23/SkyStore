let productos = [];
function agregarAlCarrito(productosJson) {

    var products = JSON.parse(productosJson);
    productos.push(products);

    guardarProductosEnLocalStorage();
    actualizarCarrito();
}
function guardarProductosEnLocalStorage() {
    // Convierte el arreglo de productos a una cadena JSON
    var carritoJson = JSON.stringify(productos);

    // Guarda la cadena JSON en localStorage
    localStorage.setItem('carritoProductos', carritoJson);
}
function cargarProductosDesdeLocalStorage() {
    // Verifica si hay datos en localStorage
    if (localStorage.getItem('carritoProductos')) {
        // Obtiene la cadena JSON del localStorage
        var carritoJson = localStorage.getItem('carritoProductos');

        // Convierte la cadena JSON en un objeto JavaScript y actualiza el arreglo de productos
        productos = JSON.parse(carritoJson);
    }
}

// Llama a la función al cargar la página para cargar los productos desde localStorage
cargarProductosDesdeLocalStorage();
function actualizarCarrito() {

    // Obtén la referencia al elemento que mostrará los datos del carrito
    var carritoElemento = document.getElementById('carritoProductos');

    // Limpia el contenido actual del carrito
    carritoElemento.innerHTML = '';

    if (productos != null) {
        for (var i = 0; i < productos.length; i++) {
            var producto = productos[i];

            // Accede a las propiedades del producto
           
            var Nombre = producto.Nombre;
            var Precio = producto.Precio;
            var Descripcion = producto.Descripcion;

            var productoElemento = document.createElement('div');
            productoElemento.innerHTML = `
            <h5>${Nombre}</h5>
            <p>Precio: ${Precio}</p>
            <p>${Descripcion}</p>
            <hr>
            `;

            // Agrega el elemento del producto al carrito
            carritoElemento.appendChild(productoElemento);
        }
        guardarProductosEnLocalStorage();
    }

}

// Manejar el evento de clic en el botón "Abrir Carrito de Compras"
document.getElementById("btnAbrirModal").addEventListener('click', function () {
    // Actualizar el carrito de compras en la ventana modal antes de mostrarlo
    actualizarCarrito();
});




//function agregarCarrito(imgProduct, nombreP, precioP, descripcionP) {
//    let comprar = document.getElementById("agregarAlCarrito");

//    const productos = [
//        {
//            imgProduct,
//            nombreP,
//            precioP,
//            descripcionP
//        },
//    ];

//    let carrito = [];

//    productos.forEach((products) => {
//        comprar.addEventListener("click", () => {
//            carrito.push({
//                imgProduct: products.imgProduct,
//                nombreP: products.nombreP,
//                precioP: products.precioP,
//                descripcionP: products.descripcionP,
//            });
//            console.log(carrito);
//        });
//    });

//    carrito.forEach((products) => {
//        let cartShop = document.getElementById("listaProducto");
//        let carritoContent = document.createElement("li");
//        carritoContent.innerHTML = `
//            <img src="${product.imgProduct}" />
//            <h3>${product.nombreP}</h3>
//            <p>${product.precioP}</p>
//            <p>$ ${product.descripcionP}</p>
//        `;
//        cartShop.append(carritoContent);
//    });

//    const total = carrito.reduce((acc, el) => acc + el.precioP, 0);

//    const footer = document.getElementsByClassName("modal-footer");
//    const totalbuy = document.createElement("p");
//    total.innerHTML = `
//        <p>$${total}</p>
//    `;
//    footer.append(totalbuy);
//}

//agregarCarrito();


