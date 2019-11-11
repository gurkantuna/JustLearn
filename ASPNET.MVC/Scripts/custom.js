$(function () {
    //$(".btnProdDelete").click(function () {

    //});
    $("#tblProduct").DataTable();
    $("#tblProduct").on("click", ".btnProdDelete", function () {
        debugger;
        var btn = $(this);
        bootbox.confirm("Do you want to really delete this product?", function (result) {
            if (result) {
                var id = btn.data("id");
                //alert(id);

                $.ajax({
                    type: "GET",
                    url: "/Product/Delete/" + id,
                    //data: { id: id },
                    success: function () {
                        console.log("Product is deleted");
                        btn.closest("tr").remove();
                    }
                })
            }
        })
    })

    $("#tblCategory").on("click", ".btnCatDel", function () {
        //debugger;

        var btn = $(this);

        bootbox.confirm("Do you want to really delete this category?", function (result) {
            if (result) {
                var id = btn.data("id");

                $.ajax({
                    type: "POST",
                    url: "/Category/Delete",
                    data: { "id": id },
                    success: function () {
                        console.log("Product is deleted")
                        btn.closest("tr").remove();
                    }
                })
            }
        })
    })
})