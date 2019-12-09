using System.Collections.Generic;
using RoleTopMVC.Models;
using RoleTopMVC.Controllers;
using RoleTopMVC.ViewModels;
using System;
using System.IO;



namespace RoleTopMVC.Repositories {
    public class ServicoRepository : RepositoryBase {
        public const string CAMINHO = "Database/Sservico.csv";

        public double ObterPrecoDe (string nomeServico) {
            var lista = ObterTodos ();
            var preco = 0.0;
            foreach (var item in lista) {
                if (item.Servico .Equals (nomeServico)) {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Servicos> ObterTodos(){

            List<Servicos> servicos = new List<Servicos>(); 

        string[] linhas = File.ReadAllLines (CAMINHO);
        foreach (var linha in linhas) {
            Produto se = new Produto();
            
            string[] dados = linha.Split (";");
            se.Nome = dados[0];
            se.Preco = double.Parse(dados[1]);
            servicos.Add(s);
        }

        return servicos;

        }

    }
}