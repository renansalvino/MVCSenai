using Hamburgueria_WebMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hamburgueria_WebMVC.Repositorios;
using Hamburgueria_WebMVC.ViewModels;
using Hamburgueria.Repositories;

namespace Hamburgueria_WebMVC.Controllers
{
    public class PedidoController : Controller
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository Repositorio = new PedidoRepository();
        private HamburguerRepositorio hamburguerRepositorio = new HamburguerRepositorio();
        private ShakeRepositorio shakeRepositorio =  new ShakeRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";

        [HttpGet]
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepositorio.Listar();
            var shakes = shakeRepositorio.Listar();
            var cliente = clienteRepository.ObterPor(HttpContext.Session.GetString(SESSION_EMAIL));

            PedidoViewModel pedido = new PedidoViewModel();
            pedido.Hamburgueres = hamburgueres;
            pedido.Shake = shakes;

            pedido.Cliente = cliente == null ? new Cliente() : cliente;
            // if (cliente == null)
            // {
            //     pedido.Cliente = new Cliente();   
            // }else
            // {
            //     pedido.Cliente = cliente;
            // }
            
            return View(pedido);
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form){
            // System.Console.WriteLine(form["nome"]);
            // System.Console.WriteLine(form["endereco"]);
            // System.Console.WriteLine(form["telefone"]);
            // System.Console.WriteLine(form["email"]);
            // System.Console.WriteLine(form["hamburguer"]);
            // System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            //FORMA UM
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];
            pedido.Cliente = cliente;

            //FORMA DOIS
            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hamburguer"],
                Preco: hamburguerRepositorio.ObterPreçoDe(form["hamburguer"])
            );
            pedido.Hamburguer = hamburguer;

            //FORMA 3 - RESUM DA FORMA 1
            Shake shake = new Shake(){
                Nome = form["shake"],
                Preco = shakeRepositorio.ObterPreçoDe(form["shake"])
            };
            pedido.Shake = shake;
            pedido.PrecoTotal = pedido.Hamburguer.Preco + pedido.Shake.Preco;

            Repositorio.Inserir(pedido);
            ViewData["NomeView"] = "Pedido";

            return View("Sucesso");
        }
    }
}