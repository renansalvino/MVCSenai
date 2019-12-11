using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using RoleTopMVC.Models;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models {
    public class Pedido {
        
        public string Nome {get;set;}
        public ulong Id { get; set; }
        public Cliente Cliente { get; set; }
        public string NomeEvento { get; set; }
        public string TipoEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public int NumeroConvidado { get; set; }
        public string Obs { get; set; }
        public Produto Servicos { get; set; }
        public uint Status { get; set; }
        public double PrecoTotal { get; set; }
        public StringValues Servico { get; internal set; }

        public Pedido ( Cliente cliente, string nomeEvento, string tipoEvento, DateTime dataEvento, int numeroConvidado, string obs,uint status, double precoTotal,int telefone,Produto Servico) {
  
           
            this.NomeEvento = nomeEvento;
            this.TipoEvento = tipoEvento;
            this.DataEvento = dataEvento;
            this.NumeroConvidado = numeroConvidado;
            this.Obs = obs;
            this.Status = (uint) StatusPedido.PENDENTE;
            this.PrecoTotal = precoTotal;
            this.Servicos = Servico;
            this.Id = 0;
        }
        public Pedido () {
            
        }
    }
}