using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC2.Repositories;
using MVC2.ViewModels;


namespace MVC2.Controllers
{
    public class LoginController : AbstractController
    {
                private ClienteRepository clienteRepository = new ClienteRepository ();
        private ServicoRepository servicoRepository = new ServicoRepository ();
        private PedidoRepository pedidoRepository = new PedidoRepository ();

        [HttpGet]
        public IActionResult Index () {
            return View (new HistoricoViewModels () {
                NomeView = "login",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession (),
            });
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            ViewData["Action"] = "Login";
            try {
                System.Console.WriteLine ("==================");
                System.Console.WriteLine (form["temail"]);
                System.Console.WriteLine (form["tsenha"]);
                System.Console.WriteLine ("==================");

                var usuario = form["temail"];
                var senha = form["tsenha"];

                var cliente = clienteRepository.ObterPor (usuario);

                if (cliente != null) {
                    if (cliente.Senha.Equals (senha)) {
                        switch (cliente.TipoUsuario) {
                            case 1:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString ());

                            return RedirectToAction ("Index", "Evento");
                            
                            default :
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString ());

                            return RedirectToAction ("Administrador", "Administrador");
                        }
                    } else {
                        return View ("Erro", new RespostaViewModel ("Senha incorreta") {
                            NomeView = "Erro",
                                UsuarioEmail = ObterUsuarioSession (),
                                UsuarioNome = ObterUsuarioNomeSession (),

                        });
                    }

                } else {
                    return View ("Erro", new RespostaViewModel ($"Usuário {usuario} não encontrado") {
                        NomeView = "Erro",
                            UsuarioEmail = ObterUsuarioSession (),
                            UsuarioNome = ObterUsuarioNomeSession (),

                    });
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel ());

            }
        }

        public IActionResult Historico () {
            var emailCliente = HttpContext.Session.GetString (SESSION_CLIENTE_EMAIL);
            var servicosCliente = pedidoRepository.ObterTodosPorCliente (emailCliente);

            return View (new HistoricoViewModels () {
                pedidos = servicosCliente,
                    NomeView = "Historico",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
            });
        }

         public IActionResult Logoff () {
            HttpContext.Session.Remove (SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove (SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
    }
}