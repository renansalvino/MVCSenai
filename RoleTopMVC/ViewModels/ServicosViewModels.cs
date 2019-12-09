using System.Collections.Generic;
using RoleTopMVC.Models;

namespace RoleTopMVC.ViewModels
{
    public class ServicosViewModel : BaseViewModel
    {
        public List<Pedido> pedidos { get; set; }
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
            this.pedidos = new List<Pedidos>();
            this.NomeUsuario = "Senhor";
        }
    }
}