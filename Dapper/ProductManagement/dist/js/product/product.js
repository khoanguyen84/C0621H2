var product = {};
var apiUrl = 'https://localhost:44383/Product';

product.showData = function () {
    $.ajax({
        url: apiUrl,
        method: "GET",
        datatype: "json",
        success: function (data) {
            data.sort(function (item1, item2) {
                return item2.productId - item1.productId;
            });
            $('#tbProduct>tbody').empty();
            $.each(data, function (index, item) {
                $('#tbProduct>tbody').append(`
                    <tr>
                        <td>${item.productId}</td>
                        <td>${item.productName}</td>
                        <td class='text-center'><img class="photo-sm" src=${item.photo}></td>
                        <td class='text-right'>
                            ${new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(Number(item.price))}
                        </td>
                        <td class='text-right'>${item.quantity.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")}</td>
                        <td>${item.manufactory}</td>
                        <td class='text-right'>
                            <span class="badge ${item.status ? 'bg-success' : 'bg-danger'}">
                                ${item.Status ? 'active' : 'inactive'}
                            </span>
                        </td>
                        <td>
                            <a href="javascript:;" class="btn btn-primary btn-sm" onclick='product.getProduct(${item.productId})'>
                                <i class="fa fa-edit"></i>
                            </a>
                            <a href="javascript:;" class="btn ${item.status ? 'btn-warning' : 'bg-secondary'}  btn-sm"
                                onclick="product.changeStatus(${item.productId}, ${item.status})">
                                <i class="fa ${item.status ? 'fa-lock-open' : 'fa-lock'}"></i>
                            </a>
                            <a href="javascript:;" class="btn btn-danger btn-sm" onclick='product.removeProduct(${item.productId})'>
                                <i class="fa fa-trash"></i>
                            </a>
                        </td>
                    </tr>
                `);
            });
            // $('#tbProduct').DataTable();
        }
    });
}


product.openModal = function () {
    $('#addEditProduct').modal('show');
    product.reset();
}

product.save = function () {
    if ($('#addEditForm').valid()) {
        if (Number($('#productId').val()) == 0) {
            let createObj = {
                ProductName: $('#productName').val(),
                Manufactory: $('#manufactory').val(),
                Price: Number($('#price').val()),
                Quantity: Number($('#quantity').val()),
                Photo: $('#photo').val(),
                Status: $('#status').is(':checked'),
            };
            $.ajax({
                url: apiUrl,
                method: "POST",
                contentType: "application/json",
                datatype: "json",
                data: JSON.stringify(createObj),
                success: function (result) {
                    if (result) {
                        $('#addEditProduct').modal('hide');
                        $.notify("Product has been created successfully!", "success");
                        product.showData();
                    }
                    else {
                        $.notify("Something went wrong, please try again!", "error");
                    }

                }
            });
        }
        else {
            let updateObj = {
                productId: Number($('#productId').val()),
                ProductName: $('#productName').val(),
                Manufactory: $('#manufactory').val(),
                Price: Number($('#price').val()),
                Quantity: Number($('#quantity').val()),
                Photo: $('#photo').val(),
                Status: $('#status').is(':checked'),
            };
            $.ajax({
                url: `${apiUrl}/${updateObj.productId}`,
                method: "PUT",
                contentType: "application/json",
                datatype: "json",
                data: JSON.stringify(updateObj),
                success: function (result) {
                    if (result) {
                        $('#addEditProduct').modal('hide');
                        $.notify("Product has been updated successfully!", "success");
                        product.showData();
                    }
                    else {
                        $.notify("Something went wrong, please try again!", "error");
                    }

                }
            });
        }


    }
}

product.reset = function () {
    $("#addEditForm").validate().resetForm();
    $('#productName').val("");
    $('#manufactory').val("");
    $('#price').val("");
    $('#quantity').val("");
    $('#photo').val("http://placeimg.com/640/480");
    $('#status').prop("checked", false);
    $('#productId').val(0);
    $('#addEditProduct').find(".modal-title").text("Create Product");
}

product.getProduct = function (id) {
    $.ajax({
        url: `${apiUrl}/${id}`,
        method: "GET",
        datatype: "json",
        success: function (product) {
            $('#productName').val(product.productName);
            $('#manufactory').val(product.manufactory);
            $('#price').val(product.price);
            $('#quantity').val(product.quantity);
            $('#photo_img').prop('src', product.photo);
            $('#photo').val(product.photo);
            $('#status').prop("checked", product.status);
            $('#productId').val(product.productId);
            $('#addEditProduct').find(".modal-title").text("Update Product");
            $('#addEditProduct').modal('show');
        }
    });
}

product.removeProduct = function (id) {
    bootbox.confirm({
        title: "Remove product?",
        message: "Do you want to remove this product now? This cannot be undone.",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `${apiUrl}/${id}`,
                    method: "DELETE",
                    datatype: "json",
                    success: function (result) {
                        if (result) {
                            $.notify("Product has been removed successfully!", "success");
                            product.showData();
                        }
                        else {
                            $.notify("Something went wrong, please try again!", "error");
                        }
                    }
                });
            }
        }
    });
}

product.changeStatus = function (id, status) {
    bootbox.confirm({
        title: `${status ? 'Inactive' : 'Active'} product?`,
        message: `Do you want to ${status ? 'inactive' : 'active'} this product now?`,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                let statusObj = {
                    Status: !status,
                    ProductId : id
                };
                $.ajax({
                    url: `${apiUrl}/ChangeStatus/${id}`,
                    method: "PUT",
                    contentType: "application/json",
                    datatype: "json",
                    data: JSON.stringify(statusObj),
                    success: function (result) {
                        if (result) {
                            $.notify(`Product has been ${status ? 'inactive' : 'active'} successfully!`, "success");
                            product.showData();
                        }
                        else {
                            $.notify("Something went wrong, please try again!", "error");
                        }

                    }
                });
            }
        }
    });
}

product.uploadPhoto = function () {

    if ($('#uploadPhoto')[0].files && $('#uploadPhoto')[0].files[0]) {
        var FR = new FileReader();
        FR.addEventListener("load", function (e) {
            $('#photo_img').prop('src', e.target.result);
            $('#photo').val(e.target.result);
        });
        FR.readAsDataURL($('#uploadPhoto')[0].files[0]);
    }
}
$(document).ready(function () {
    product.showData();
});