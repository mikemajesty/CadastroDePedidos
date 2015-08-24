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
            var item = banco.Itens.Where(c=>c.ItensID.Equals(ItensID));
            ViewBag.Pedido = ItensID;
            return PartialView(item);
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