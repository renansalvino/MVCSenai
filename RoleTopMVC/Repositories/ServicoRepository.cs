using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Controllers;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Repositories {
    public class ServicoRepository : RepositoryBase {
        public const string CAMINHO = "Database/Servico.csv";

        public double ObterPrecoDe (string nomeServico) {
            var lista = ObterTodos ();
            var preco = 0.0;
            foreach (var item in lista) {
                if (item.Preco.Equals (nomeServico)) {
                    preco = item.Preco;
                    break;
                }
            }
            return preco;
        }

        public List<Produto> ObterTodos () {

            List<Produto> servicos = new List<Produto> ();

            string[] linhas = File.ReadAllLines (CAMINHO);
            foreach (var linha in linhas) {
                Produto servico = new Produto ();

                string[] dados = linha.Split (";");
                servico.Nome = dados[0];
                servico.Preco = double.Parse (dados[1]);
                servicos.Add (servico);
            }

            return servicos;

        }

    }
}