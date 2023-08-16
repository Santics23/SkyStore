﻿var idp;
var table;
var listaProducto;

$(document).ready(function () {
    table = $('#DataTableProduct').DataTable({
        data: jsonData,
        columns: [
            { data: 'Codigo' },
            { data: 'Nombre' },
            { data: 'Precio' },
            { data: 'Descripcion' },
            { data: 'Imagen' },
            { data: 'Stock' },
            { data: 'Estado' },
            { data: 'Promocion' },
            { data: 'Descuento' },
            { data: 'idSubCategoria' },
            {
                data: null,
                "defaultContent": "<div class='text-center'><div class='btn-group'><button class='btn btn-primary btn-sm btnEditar'><i class='material-icons'>edit</i></button><button class='btn btn-danger btn-sm btnBorrar'><i class='material-icons'>delete</i></button></div></div>",
            },

        ],
        scrollY: '400px',
        scrollX: true,
        autoWidth: false
    });
});

$('#DataTableProduct').on('click', '.btnEditar', function (e) {
    e.preventDefault();
    var rowData = $('#DataTableProduct').DataTable().row($(this).closest('tr')).data();
    idp = rowData.idProducto;

    $.ajax({
        url: "AdministrarProducts.aspx/mtdCargarDatos",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify({ idProducto: idp }),
        success: function (Data) {

            var datosProducto = Data.d;
            $('.txt-codigo').val(datosProducto[0]["Codigo"]);
            $('.txt-nombre').val(datosProducto[0]["Nombre"]);
            $('.txt-precio').val(datosProducto[0]["Precio"]);
            $('.txt-descripcion').val(datosProducto[0]["Descripcion"]);
            $('.txt-stock').val(datosProducto[0]["Stock"]);
            $('.txt-estado').val(datosProducto[0]["Estado"]);
            $('.txt-promo').val(datosProducto[0]["Promocion"]);
            $('.txt-desc').val(datosProducto[0]["Descuento"]);
            $('.txt-subcateg').val(datosProducto[0]["idSubCategoria"]);

            $('#editarModal').modal('show');
        },
        error: function (error) {
            console.log(error);
        }
    });

});

$('#btnActualizar').on('click', function (e) {
    e.preventDefault();
    var idProducto = idp;
    var Codigo = $('.txt-codigo').val();
    var Nombre = $('.txt-nombre').val();
    var Precio = $('.txt-precio').val();
    var Descripcion = $('.txt-descripcion').val();
    var Imagen = $('.txt-imagen').val();
    var Stock = $('.txt-stock').val();
    var Estado = $('.txt-estado').val();
    var Promocion = $('.txt-promo').val();
    var Descuento = $('.txt-desc').val();
    var SubCategoria = $('.txt-subcateg').val();

    var DatosActualizados = {
        idProducto: idProducto,
        Codigo: Codigo,
        Nombre: Nombre,
        Precio: Precio,
        Descripcion: Descripcion,
        Imagen: Imagen,
        Stock: Stock,
        Estado: Estado,
        Promocion: Promocion,
        Descuento: Descuento,
        idSubCategoria: SubCategoria
    };

    // Realiza la petición Ajax
    $.ajax({
        url: "AdministrarProducts.aspx/mtdActualizarProducto",
        type: "POST",
        data: JSON.stringify({ data: DatosActualizados }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {

            recargarTabla();
            swal("¡Éxito!", "Los datos se actualizaron correctamente.", "success");
            $('#editarModal').modal('hide'); // Cierra la ventana modal
        },
        error: function (error) {
            console.log(error);
        }

    });
});

function recargarTabla() {
    $.ajax({
        url: "AdministrarProducts.aspx/mtdListar",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            listaProducto = response.d;
            // Limpiar los datos actuales de la tabla
            table.clear();
            // Agregar los nuevos datos a la tabla
            table.rows.add(listaProducto);
            // Dibujar la tabla con los datos actualizados
            table.draw();

            console.log(listaProducto);
        },
        error: function (error) {
            console.log(error);
        }
    });
}

$('#DataTableProduct').on('click', '.btnBorrar', function (e) {
    e.preventDefault();

    var rowData = $('#DataTableProduct').DataTable().row($(this).closest('tr')).data();
    var idp = rowData.idProducto;

    swal({
        title: "¿Estás seguro?",
        text: "Esta acción no se puede deshacer",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Sí, eliminar",
        cancelButtonText: "Cancelar"
    }).then(function (result) {
        if (result.isConfirmed) {
            // Código para eliminar el registro

            var data = {
                formData: {
                    idProducto: idp
                }
            };

            // Realiza la petición Ajax para eliminar el registro
            $.ajax({
                url: "AdministrarProducts.aspx/mtdEliminar",
                type: "POST",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (Data) {
                    if (Data) {
                        swal("¡Éxito!", "Los datos se eliminaron correctamente.", "success");
                    }
                    recargarTabla();
                },
                error: function (error) {
                    console.log(error);
                }
            });
        }
    });
});
