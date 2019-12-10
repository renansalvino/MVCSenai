using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
    public class EventoController : AbstractController {
        ServicoRepository servicoRepository = new ServicoRepository ();
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();

        public IActionResult Index () {
            ServicosViewModel svm = new ServicosViewModel ();
            svm.pedidos = pedidoRepository.ObterTodos();
            svm.servicos = servicoRepository.ObterTodos();

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

            var Som = form["som"];
            Produto som = new Produto ();
            som.Nome = Som;
            som.Preco = servicoRepository.ObterPrecoDe(Som);

            pedido.Servico = Som;

            var Iluminacao = form["iluminacao"];
            Produto Iluminação = new Produto ();
            Iluminação.Nome = Iluminacao;
            Iluminação.Preco = servicoRepository.ObterPrecoDe(Iluminacao);

            pedido.Servico = Iluminacao;
            Cliente cliente = new Cliente();
            Pedido pedidos = new Pedido () {

                NomeEvento = form["NomeEvento"],
                TipoEvento = form["tipoevento"],
                DataEvento = DateTime.Parse (form["dataevento"]),
                NumeroConvidado = int.Parse(form["numeroconvidado"]),
                Obs = form["observacoes"],
             
            };

            pedido.Cliente  = cliente;

            pedido.DataEvento = DateTime.Now;

            pedido.PrecoTotal = som.Preco + som.Preco;

            if (pedidoRepository.Inserir (pedido)) {
                return View ("Sucesso", new RespostaViewModel () {
                    NomeView = "evento",
                        UsuarioEmail = ObterUsuarioSession (),
                        UsuarioNome = ObterUsuarioNomeSession ()
                });
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