using System;
using System.Collections.Generic;
using MVC2.Enums;

namespace MVC2.Models
{
    public class Pedido
    {
            public ulong Id { get; set; }
        public Cliente Cliente { get; set; }
        public string NomeEvento { get; set; }
        public string TipoEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public int NumeroConvidado { get; set; }
        public string Obs { get; set; }
        public List <Produto> Produtos { get; set; }
        public uint Status { get; set; }
        public double PrecoTotal { get; set; }
        public string ListaDeProdutos {get;set;}
        
        public Pedido ( Cliente cliente, string nomeEvento, string tipoEvento, DateTime dataEvento, int numeroConvidado, string obs,uint status, double precoTotal,int telefone,List <Produto> produtos) {
  
           
            this.NomeEvento = nomeEvento;
            this.TipoEvento = tipoEvento;
            this.DataEvento = dataEvento;
            this.NumeroConvidado = numeroConvidado;
            this.Obs = obs;
            this.Status = (uint) StatusPedido.PENDENTE;
            this.PrecoTotal = precoTotal;
            this.Produtos = produtos;
            this.Id = 0;
            this.Cliente = cliente;
        }
        public Pedido () {
            this.Cliente = new Cliente();
            this.Produtos = new List<Produto>();
        }
    }
}