var product = {};

product.showData = function(){
    $.ajax({
        url : "https://616e3eb5a83a850017caa8a6.mockapi.io/products",
        method : "GET",
        contentType : "JSON",
        success : function(data){
            console.log(data);
            $.each(data, function(index, item){
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
                            <a href="javascript:;" class="btn btn-primary btn-sm">
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

$(document).ready(function(){
    product.showData();
});