using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels {
    public class HistoricoViewModels : BaseViewModel {
        public List <Pedido> pedidos  { get; set; }
    }
}