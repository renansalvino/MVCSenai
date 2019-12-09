using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
    public class PedidoController : AbstractController {
        ServicoRepository servicoRepository = new ServicoRepository ();
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();

        public IActionResult Index () {
            ServicosViewModel pedido = new ServicosViewModel ();
            pedido.Servicos = servicoRepository.ObterTodos;

            var usuarioLogado = ObterUsuarioSession ();
            var nomeUsuarioLogado = ObterUsuarioNomeSession ();
            if (!string.IsNullOrEmpty (nomeUsuarioLogado)) {
                pedido.NomeUsuario = nomeUsuarioLogado;
            }

            pedido.NomeView = "Cadastro do evento";
            pedido.UsuarioEmail = usuarioLogado;
            pedido.UsuarioNome = nomeUsuarioLogado;

            return View ();

        }
        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "evento";
            Pedido pedido = new Pedido ();

            var Som = form["som"];
            Servico servico = new Servico ();
            servico.Nome = Som;
            servico.Preco = servicoRepository.ObterPrecoDe (Som);

            pedido.Servico = Som;

            var Iluminacao = form["iluminacao"];
            Iluminação iluminacao = new Iluminação (
                Iluminação,
                pedidoRepository.ObterPrecoDe (Iluminação));

            pedido.Servico = Iluminação;

            Pedido evento = new Pedido () {

                NomeEvento = form["tevento"],
                TipoEvento = form["tipoevento"],
                DataEvento = DateTime.Parse (form["dataevento"]),
                NumeroConvidado = form["numeroconvidado"],
                Obs = form["observacoes"],
            };

            pedido.Cliente = cliente;

            pedido.DataEvento = DateTime.Now;

            pedido.PrecoTotal = servico.Preco + servico.Preco;

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