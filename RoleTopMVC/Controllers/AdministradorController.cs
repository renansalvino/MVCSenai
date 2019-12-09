using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Enums;
using RoleTopMVC.Models;
using RoleTopMVC.Repositories;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedido = new PedidoRepository();
        ServicoRepository servicoRepository = new ServicoRepository ();
        public IActionResult Administrador()
        {
               var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())) {

                var pedidos = pedido.ObterTodos ();
                DashboardViewModel dashboardViewModel = new DashboardViewModel ();

                foreach (var pedido in pedidos) {
                    switch (pedido.Status) {
                        case (int) StatusPedido.APROVADO:
                            dashboardViewModel.ServicosAprovados++;
                            break;
                        case (int) StatusPedido.REPROVADO:
                            dashboardViewModel.ServicosReprovados++;
                            break;
                        default:
                            dashboardViewModel.ServicosPendentes++;
                            dashboardViewModel.Servicos.Add (pedido);
                            break;
                    }
                }
                dashboardViewModel.NomeView = "Dashboard";
                dashboardViewModel.UsuarioEmail = ObterUsuarioSession ();

                return View (dashboardViewModel);
            } 
            else 
            {
                return View ("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não tem permissão para acessar o Dashboard irmão"
                });

            }
        }

    }
}
