using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Pedido> Pedidos {get;set;} 

        public uint ServicosAprovados {get;set;}
        public uint ServicosReprovados {get;set;}
        public uint ServicosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Pedidos = new List <Pedido>();
        }    
      
}
}