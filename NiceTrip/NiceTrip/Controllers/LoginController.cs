using NiceTrip.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NiceTrip.Controllers
{
    public class LoginController : Controller
    {
        // GET: CadastroLogin
        public ActionResult Login()
        {
            Pessoa p = new Pessoa();
            ViewBag.p = p;

            return View();
        }
        public ActionResult Cadastro()
        {
            Pessoa p = new Pessoa();
            ViewBag.p = p;

            return View();
        }
    }
}