using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
    public class LoginController : AbstractController {

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
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString ());

                                return RedirectToAction ("Historico", "login");

                            default:
                                HttpContext.Session.SetString (SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString (SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString (SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString ());

                                return RedirectToAction ("Dashboard", "Administrador");

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
                return View ("Erro");

            }
        }

        public IActionResult Historico () {
            var emailCliente = ObterUsuarioSession ();
            var servicosCliente = pedidoRepository.ObterTodosPorCliente (emailCliente);

            return View (new HistoricoViewModels () {
                pedidos = servicosCliente,
                    NomeView = "Historico",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession ()
            });
        }

        IActionResult Logoff () {
            HttpContext.Session.Remove (SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove (SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear ();
            return RedirectToAction ("Index", "Home");
        }
    }
}