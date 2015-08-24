function SalvarPedido()
{
    var cliente = $('#Clientes').val();
    var data = $('#Data').val();
    var valor =  $('#Valor').val();
    debugger
    $.ajax(
        {
            
            url: "/Pedidos/Create",
            type: "Post",
            datatype: "json",
            data: {PedidoID: 0,Clientes:cliente,Valor:valor,Data:data},
            success:function(retorno)
            {
                if (retorno.Resultado > 0) {
                    debugger
                    window.location.href = "/Pedidos/Index";
                    //ListarItens(data.Resultado);
                }
            }
        });


}