var product = {};

product.showData = function () {
    $.ajax({
        url: "https://616e3eb5a83a850017caa8a6.mockapi.io/products",
        method: "GET",
        datatype: "json",
        success: function (data) {
            data.sort(function (item1, item2) {
                return item2.id - item1.id;
            });
            $('#tbProduct').empty();
            $.each(data, function (index, item) {
                $('#tbProduct').append(`
                    <tr>
                        <td>${item.id}</td>
                        <td>${item.ProductName}</td>
                        <td class='text-center'><img class="photo-sm" src=${item.Photo}></td>
                        <td class='text-right'>
                            ${new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(Number(item.Price))}
                        </td>
                        <td class='text-right'>${item.Quantity.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")}</td>
                        <td>${item.Manufactory}</td>
                        <td class='text-right'>
                            <span class="badge ${item.Status ? 'bg-success' : 'bg-danger'}">
                                ${item.Status ? 'active' : 'inactive'}
                            </span>
                        </td>
                        <td>
                            <a href="javascript:;" class="btn btn-primary btn-sm" onclick='product.getProduct(${item.id})'>
                                <i class="fa fa-edit"></i>
                            </a>
                            <a href="javascript:;" class="btn ${item.Status ? 'btn-warning' : 'bg-secondary'}  btn-sm">
                                <i class="fa ${item.Status ? 'fa-lock-open' : 'fa-lock'}"></i>
                            </a>
                            <a href="javascript:;" class="btn btn-danger btn-sm">
                                <i class="fa fa-trash"></i>
                            </a>
                        </td>
                    </tr>
                `);
            });
        }
    });
}


product.openModal = function () {
    $('#addEditProduct').modal('show');
    product.reset();
}

product.save = function () {
    if ($('#addEditForm').valid()) {
        if(Number($('#productId').val()) == 0){
            let createObj = {
                ProductName: $('#productName').val(),
                Manufactory: $('#manufactory').val(),
                Price: $('#price').val(),
                Quantity: Number($('#quantity').val()),
                Photo: "http://placeimg.com/640/480",
                Status: $('#status').is(':checked'),
            };
            $.ajax({
                url: "https://616e3eb5a83a850017caa8a6.mockapi.io/products",
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
        else{
            let updateObj = {
                id: Number($('#productId').val()),
                ProductName: $('#productName').val(),
                Manufactory: $('#manufactory').val(),
                Price: $('#price').val(),
                Quantity: Number($('#quantity').val()),
                Photo: "http://placeimg.com/640/480",
                Status: $('#status').is(':checked'),
            };
            $.ajax({
                url: `https://616e3eb5a83a850017caa8a6.mockapi.io/products/${updateObj.id}`,
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
        url: `https://616e3eb5a83a850017caa8a6.mockapi.io/products/${id}`,
        method: "GET",
        datatype: "json",
        success: function (product) {
            $('#productName').val(product.ProductName);
            $('#manufactory').val(product.Manufactory);
            $('#price').val(product.Price);
            $('#quantity').val(product.Quantity);
            $('#photo').val(product.Photo);
            $('#status').prop("checked", product.Status);
            $('#productId').val(product.id);
            $('#addEditProduct').find(".modal-title").text("Update Product");
            $('#addEditProduct').modal('show');
        }
    });
}

$(document).ready(function () {
    product.showData();
});