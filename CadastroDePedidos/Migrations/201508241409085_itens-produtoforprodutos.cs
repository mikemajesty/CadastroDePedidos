namespace CadastroDePedidos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itensprodutoforprodutos : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Itens", name: "Pedidos_PedidosID", newName: "Pedido_PedidosID");
            RenameIndex(table: "dbo.Itens", name: "IX_Pedidos_PedidosID", newName: "IX_Pedido_PedidosID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Itens", name: "IX_Pedido_PedidosID", newName: "IX_Pedidos_PedidosID");
            RenameColumn(table: "dbo.Itens", name: "Pedido_PedidosID", newName: "Pedidos_PedidosID");
        }
    }
}
