using System.Collections.Generic;
using MVC2.Models;

namespace MVC2.ViewModels
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