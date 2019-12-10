using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using RoleTopMVC.Models;
using RoleTopMVC.Enums;

namespace RoleTopMVC.Models {
    public class Pedido {

        public string Nome {get;set;}
        public int Telefone {get;set;}
        public double Preco {get;set;}
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

        public Pedido (ulong id, Cliente cliente, string nomeEvento, string tipoEvento, DateTime dataEvento, int numeroConvidado, string obs, Produto Iluminação, Produto som, uint status, double precoTotal,int telefone) {
            this.Id = 0;
            this.Cliente = cliente;
            this.NomeEvento = nomeEvento;
            this.TipoEvento = tipoEvento;
            this.DataEvento = dataEvento;
            this.NumeroConvidado = numeroConvidado;
            this.Obs = obs;
            this.Status = (uint) StatusPedido.PENDENTE;
            this.PrecoTotal = precoTotal;
            this.Telefone = telefone;

        }
        public Pedido () {

        }
    }
}