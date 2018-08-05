$(document).ready(function () {
    $('#AddData').hide();
    $('#UpdateData').hide();

    $('#BtnAdd').click(function () {
        $('#AddData').toggle();
    });
    $('#BtnUpdate').click(function () {
        $('#UpdateData').toggle();
    });

    $('#SubmitAddData').click(function () {
        var GetData = {
            ProductID: $('#ProductID').val(),
            ProductName: $('#ProductName').val(),
            ProductPrice: $('#ProductPrice').val()
        };

        $.ajax({
            type: "POST",
            contentType: "application/json; charset=utf-8",
            url: "api/Product/GetData",
            data: JSON.stringify(GetData),
            dataType: "json",
            success: function (result) {
                console.log(result);
            },
            error: function (ex) {
                alert(ex);
            }
        });
    });

});