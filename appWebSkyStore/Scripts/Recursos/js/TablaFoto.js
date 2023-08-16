$(document).ready(function () {
    $('#DataTableExplicacion').DataTable({

        data: jsonData,
        type: "post",
        dom: 'Bfrtilp',

        "columns": [

            {
                "data": "Foto",
                "render": function (data, type, row) {
                    if (type === 'display') {
                        return '<img src="' + data + '" alt="Foto" width="50" height="50">';
                    }
                    return data;
                }
            },
            { "data": "Documento" },
            { "data": "Nombre" },
            { "data": "Apellido" },
            { "data": "Ciudad" },
            { "data": "Telefono" },
            {
                "data": null,
                "defaultContent": "<div class='text-center'><div class='btn-group'><button class='btn btn-primary btn-sm btnEditar'><i class='material-icons'>Detalles</i></button></div></div>",
                "createdCell": function (td, cellData, rowData, row, col) {
                    $(td).find('.btnEditar').attr('data-id', rowData.IdProducto);
                }
            }
        ]

    });
    console.log(data);
});