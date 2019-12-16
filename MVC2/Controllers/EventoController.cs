using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC2.Enums;
using MVC2.Models;
using MVC2.Repositories;
using MVC2.ViewModels;


namespace MVC2.Controllers
{
    public class EventoController : AbstractController
    {
         ServicoRepository servicoRepository = new ServicoRepository ();
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();
        Cliente cliente = new Cliente ();
        public IActionResult Index () {
            ServicosViewModel svm = new ServicosViewModel ();
            svm.pedidos = pedidoRepository.ObterTodos ();
            svm.servicos = servicoRepository.ObterTodos ();

            var usuarioLogado = ObterUsuarioSession ();
            var nomeUsuarioLogado = ObterUsuarioNomeSession ();
            if (!string.IsNullOrEmpty (nomeUsuarioLogado)) {
                svm.NomeUsuario = nomeUsuarioLogado;
            }

            svm.NomeView = "evento";
            svm.UsuarioEmail = usuarioLogado;
            svm.UsuarioNome = nomeUsuarioLogado;

            return View (svm);

        }
        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "evento";

            Pedido pedido = new Pedido ();

            List<Produto> produtos = new List<Produto> ();

            string[] nomesServicos = form["pacote"].ToString ().Split (",");

            foreach (string nomeServico in nomesServicos) {
                System.Console.WriteLine (nomesServicos);
                produtos.Add (new Produto (nomeServico, servicoRepository.ObterPrecoDe (nomeServico)));
            }
            // var Iluminacao = form["iluminacao"];
            // Produto Iluminação = new Produto ();
            // Iluminação.Nome = Iluminacao;
            // Iluminação.Preco = servicoRepository.ObterPrecoDe (Iluminacao);

            var emailCliente = ObterUsuarioSession ();
            // pedido.Servico = Iluminacao;

            Cliente cliente = clienteRepository.ObterPor (emailCliente);
            pedido.Produtos = produtos;
            pedido.Cliente = cliente;
            pedido.NomeEvento = form["NomeEvento"];
            pedido.TipoEvento = form["tipoevento"];
            pedido.DataEvento = DateTime.Parse (form["dataevento"]);
            pedido.NumeroConvidado = int.Parse (form["numeroconvidado"]);
            pedido.Obs = form["observacoes"];

            pedido.DataEvento = DateTime.Now;

            foreach (var produto in produtos) {
                pedido.PrecoTotal += produto.Preco;
            }

            if (pedidoRepository.Inserir (pedido)) {
                // return View ("Sucesso", new RespostaViewModel () {
                //     NomeView = "evento",
                //     UsuarioEmail = ObterUsuarioSession (),
                //     UsuarioNome = ObterUsuarioNomeSession ()                        
                //}

                return RedirectToAction ("Historico", "login");

            } else {
                return View ("Erro", new RespostaViewModel () {
                    NomeView = "evento",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
            }

        }

        public IActionResult Aprovar (ulong id) {
            var servico = pedidoRepository.ObterPor (id);
            servico.Status = (uint) StatusPedido.REPROVADO;

            if (pedidoRepository.Atualizar (servico)) {
                return View ("Erro", new RespostaViewModel ("Não foi possivel aprovar seu evento") {
                    NomeView = "Dashboard",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
            }
            return View (); //eu quem coloquei, ver a merda que da depois
        }
    }
}