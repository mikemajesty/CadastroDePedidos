using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroDePedidos.Models
{
    public class ItemViewModel
    {
        public int Quantidade { get; set; }
        public string  Produto { get; set; }
        public decimal ValorUnitario { get; set; }
        public int IdPedido { get; set; }
    }
}