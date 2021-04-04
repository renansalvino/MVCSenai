using Hamburgueria.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria_WebMVC.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form) {
            var usuario = form["email"];
            var senha = form["senha"];
            var cliente = clienteRepository.ObterPor(usuario); //aq é email == "usuario"

            if (cliente != null && cliente.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);//Funciona como um dicionario, (key,dado)
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout (){
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}