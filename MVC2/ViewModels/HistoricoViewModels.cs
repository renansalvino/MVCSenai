using System.Collections.Generic;
using MVC2.Models;

namespace MVC2.ViewModels
{
    public class HistoricoViewModels : BaseViewModel
    {
           public List <Pedido> pedidos  { get; set; }
    }
}