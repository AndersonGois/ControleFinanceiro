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
            var usuario = new UsuarioView {Login = "Anderson", Senha = "123"};
            var usu = usuario.ObterUsuarioPorLoginSenha(usuario);
            return View(usu);
        }

    }
}
