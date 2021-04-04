using System;
using Hamburgueria.Repositories;
using Hamburgueria_WebMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria_WebMVC.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index(){
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];
            cliente.Senha = form["senha"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            clienteRepository.Inserir(cliente);
            ViewData["Action"] = "Cadastro";
            return View("Sucesso");

            

        }
    }
}