using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controle.View;

namespace MvcApplication1.Controllers
{
    public class LoginController : Controller
    {
        

        public ActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult Index(UsuarioView usuarioView)
        {
            var usuario = new UsuarioView { Login = "ANderson", Senha = "123" };
            var usu = usuario.ObterUsuarioPorLoginSenha(usuario);

            var entrada = new EntradaView {Usuario = usu};
         return   RedirectToAction("Index", "Entrada", entrada);
        }

    }
}
