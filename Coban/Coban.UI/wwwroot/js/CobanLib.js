var Lib = {
    SweetAlertNotification: function (icon,err,time = 1500) {
        Swal.fire({
            position: 'top-end',
            icon: icon,
            title: err,
            showConfirmButton: false,
            timer: time
        });
    }
};



