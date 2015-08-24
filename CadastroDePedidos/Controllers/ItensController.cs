using CadastroDePedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroDePedidos.Controllers
{
    public class ItensController : Controller
    {
        DataContext banco = new DataContext();
        public ActionResult ListarItens(int ItensID)
        {
            var item = banco.Itens.Where(c=>c.Pedido.PedidosID == ItensID);
            ViewBag.Pedido = ItensID;
            return PartialView(item);
        }
        [HttpGet]
        public ActionResult SalvarItens(ItemViewModel itemViewModel)
        {
            var item = new Itens
            {
                Quantidade = itemViewModel.Quantidade,
                Produto = itemViewModel.Produto,
                Pedido = banco.Pedidos.Find(itemViewModel.IdPedido),
                ValorUnitario = itemViewModel.ValorUnitario
            };
            banco.Itens.Add(item);
            banco.SaveChanges();
            return Json(new {Resultado  = item.ItensID},JsonRequestBehavior.AllowGet);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                banco.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}