// script.js
function MostrarSweetAlert() {
    Swal.fire({
        title: '¡Usuario No ha Iniciado Sesión!',
        text: 'Antes de Empezar, Inicie Sesión',
        icon: 'warning',
        confirmButtonText: 'Ok',
    }).then(function (result) {
        if (result.isConfirmed) {
            window.location.href = 'Home.aspx'; // Cambia la URL por la página a la que quieres redirigir
        }
    });
}

function MostrarSweetAlert1() {
    Swal.fire({
        title: '¡Usuario No encontrado!',
        text: 'No se preocupe, Aquí lo enviaremos para que se registre',
        icon: 'warning',
        confirmButtonText: 'Ok',
    }).then(function (result) {
        if (result.isConfirmed) {
            window.location.href = 'RegistrarAdminTienda.aspx'; // Cambia la URL por la página a la que quieres redirigir
        }
    });
}

function sweetAlert() {
    Swal.fire({
        title: '¡Campos Vacios',
        text: '¡Vaya, parece que hay campos vacios!',
        icon: 'warning'
    })
}

function sweetAlert2(title, text, icon) {
    Swal.fire({
        title: title,
        text: text,
        icon: icon
    })
}

function sweetAlert3(title , text) {
    Swal.fire({
        title: title,
        text: text,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, Registrarme!'
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire(
                'No!',

            )
        }
    })
}