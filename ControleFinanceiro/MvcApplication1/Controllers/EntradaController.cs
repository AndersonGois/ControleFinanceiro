using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controle.View;

namespace MvcApplication1.Controllers
{
    public class EntradaController : Controller
    {
        //
        // GET: /Entrada/

        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index2(EntradaView entradaView)
        {
            entradaView.Data = DateTime.Now;

            if (string.IsNullOrEmpty(entradaView.Nome))
            {
                ModelState.AddModelError("Nome", "Nome é obrigatório");
                return View();
            }

            entradaView.InserirEntrada(entradaView);
            entradaView = new EntradaView();
            return View(entradaView);
        }
    }
}
