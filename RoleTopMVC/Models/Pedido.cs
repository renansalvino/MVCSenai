using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using RoleTopMVC.Models;


namespace RoleTopMVC.Models {
    public class Pedido {
       
        public ulong Id { get; set; }
        public Cliente Cliente { get; set; }
        public string NomeEvento { get; set; }
        public string TipoEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public int NumeroConvidado { get; set; }
        public string Obs { get; set; }
        public Servicos Iluminação {get;set;}
        public Servicos Som {get;set;}
        public uint Status {get;set;}
        public double PrecoTotal { get; set; }
        public StringValues Servico { get; internal set; }

        public Pedido(ulong id, Cliente cliente, string nomeEvento, string tipoEvento, DateTime dataEvento, int numeroConvidado, string obs,Servicos Iluminação, Servicos som, uint status, double precoTotal) 
        {
            this.Id = id;
                this.Cliente = cliente;
                this.NomeEvento = nomeEvento;
                this.TipoEvento = tipoEvento;
                this.DataEvento = dataEvento;
                this.NumeroConvidado = numeroConvidado;
                this.Obs = obs;
                this.Som = som;
                this.Status = 0;
                this.PrecoTotal = precoTotal;
               
        }
        public Pedido () {

        }
    }
}