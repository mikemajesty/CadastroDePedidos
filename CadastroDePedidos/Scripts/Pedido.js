function SalvarPedido()
{
    var cliente = $('#Clientes').val();
    var data = $('#Data').val();
    var valor =  $('#Valor').val();
   
    $.ajax({
            
            url: "/Pedidos/Create",
            type: "POST",
            datatype: "json",
            data: {PedidoID: 0,Clientes:cliente,Valor:valor,Data:data},
            success:function(retorno)
            {
              
                if (retorno.Resultado > 0) {
                    debugger
                    ListarItens(retorno.Resultado);
                }
            }
        });


}
function ListarItens(idItem) {

    $.ajax({

            url: "/Itens/ListarItens",
            type: "GET",
            data: { ItensID: idItem },
            datatype: "html",
            success: function (data) {
                debugger
                var divItens = $('#divItens');
                divItens.empty();
                divItens.show();
                divItens.html(data);
            }

        });


}

