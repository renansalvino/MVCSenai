using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC2.Enums;
using MVC2.Models;
using MVC2.Repositories;
using MVC2.ViewModels;


namespace MVC2.Controllers
{
    public class CadastroController : AbstractController
    {
             ClienteRepository clienteRepository = new ClienteRepository ();

        public IActionResult Index () {

            return View (new BaseViewModel () {
                NomeView = "cadastro",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession (),
            });
        }

        public IActionResult CadastrarCliente (IFormCollection form) {
            ViewData["Action"] = "Cadastro";
            try {
                Cliente cliente = new Cliente (
                    form["nome"],
                    form["telefone"],
                    form["senha"],
                    form["email"],
                    form["CPF"],
                    DateTime.Parse (form["date"]));
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                clienteRepository.Inserir (cliente);
                return View ("Sucesso", new RespostaViewModel () {
                    NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro", new RespostaViewModel () {
                    NomeView = "Cadastro",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession (),
                });
            }

        }
    }
}