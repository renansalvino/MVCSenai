using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Pedido> Servicos {get;set;} 

        public uint ServicosAprovados {get;set;}
        public uint ServicosReprovados {get;set;}
        public uint ServicosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Servicos = new List <Evento>();
        }
    }
}