using System.Collections.Generic;
using Hamburgueria_WebMVC.Models;

namespace Hamburgueria_WebMVC.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shake {get;set;}   
        public Cliente Cliente {get;set;}
    }
}