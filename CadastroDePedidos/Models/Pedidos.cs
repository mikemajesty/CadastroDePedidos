using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroDePedidos.Models
{
    [Table(name:nameof(Pedidos))]
    public class Pedidos
    {
        [Key]
        public int PedidosID { get; set; }
        public DateTime Data { get; set; }
        public string Clientes { get; set; }
        public Decimal Valor { get; set; }
    }
}