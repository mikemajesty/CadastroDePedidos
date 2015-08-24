using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroDePedidos.Models
{
    [Table(name:nameof(Itens))]
    public class Itens
    {
        public int ItensID { get; set; }
        public Pedidos Pedidos { get; set; }
        public int Quantidade { get; set; }
        public string Produto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}