using System.Collections.Generic;
using MVC2.Models;

namespace MVC2.ViewModels
{
    public class ServicosViewModel : BaseViewModel
    {
          public List<Pedido> pedidos { get; set; }
        public List<Produto> servicos {get;set;}

        public ServicosViewModel(string nomeUsuario, Cliente cliente)
        {
            this.NomeUsuario = nomeUsuario;
            this.Cliente = cliente;

        }
        public string NomeUsuario { get; set; }
        public Cliente Cliente { get; set; }

        public ServicosViewModel()
        {
            this.Cliente = new Cliente();
            this.pedidos = new List<Pedido>();
            this.servicos = new List<Produto>();
            this.NomeUsuario = "Senhor";
        }
    }
}