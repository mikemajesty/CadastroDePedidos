function ListarItens(idItem) {
    
    $.ajax(
        {
            url: "/Itens/ListarItens",
            type: "Get",
            data: { ItensID: idItem },
            success: function (data) {
                debugger
                var divItens = $('#divItens');
                divItens.empty();
                divItens.show();
                divItens.html(data);
            }

        }

        );


}

