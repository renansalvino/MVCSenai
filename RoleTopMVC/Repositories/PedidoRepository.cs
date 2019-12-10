using System;
using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories {
    public class PedidoRepository : RepositoryBase {

        private const string CAMINHO = "Database/Pedido.csv";
        public PedidoRepository () {
            if (!File.Exists (CAMINHO)) {
                File.Create (CAMINHO).Close ();
            }

        }
        public bool Inserir (Pedido servico) {
            var quantidadedeServicos = File.ReadAllLines (CAMINHO).Length;
            servico.Id = (ulong) ++quantidadedeServicos;
            var linha = new string[] { PrepararServicoCSV (servico) };
            File.AppendAllLines (CAMINHO, linha);

            return true;

        }

        public List<Pedido> ObterTodosPorCliente (string emailCliente) {
            var servicos = ObterTodos ();
            List<Pedido> servicosCliente = new List<Pedido> ();

            foreach (var servico in servicos) {
                if (servico.Cliente.Email.Equals (emailCliente)) {
                    servicosCliente.Add (servico);
                }
            }
            return servicosCliente;
        }

        public List<Pedido> ObterTodos () {

            var linhas = File.ReadAllLines (CAMINHO);
            List<Pedido> servicos = new List<Pedido> ();

            foreach (var linha in linhas) {
                Pedido servico = new Pedido ();

                servico.NomeEvento = ExtrairValorDoCampo ("NomeEvento", linha);
                servico.TipoEvento = ExtrairValorDoCampo ("tipoevento", linha);
                servico.DataEvento = DateTime.Parse (ExtrairValorDoCampo ("dataevento", linha));
                servico.NumeroConvidado = int.Parse (ExtrairValorDoCampo ("numeroconvidado", linha));
                servico.Obs = ExtrairValorDoCampo ("observacoes", linha);
                servicos.Add (servico);
            }
            return servicos;
        }
        public Pedido ObterPor (ulong id) {
            var pedidosTotais = ObterTodos ();
            foreach (var pedido in pedidosTotais) {
                if (id.Equals (pedido.Id)) {
                    return pedido;
                }
            }
            return null;
        }

        public bool Atualizar (Pedido pedido) {
            var pedidosTotais = File.ReadAllLines (CAMINHO);
            var pedidoCSV = PrepararServicoCSV (pedido);
            var linhaPedido = -1;
            var resultado = false;

            for (int i = 0; i < pedidosTotais.Length; i++) {
                var idConvertido = ulong.Parse (ExtrairValorDoCampo ("id", pedidosTotais[i]));
                if (pedido.Id.Equals (idConvertido)) {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if (resultado) {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines (CAMINHO, pedidosTotais);
            }

            return resultado;
        }
        public string PrepararServicoCSV (Pedido servico) {
            Pedido pedido = servico;
            return $"NomeEvento={servico.NomeEvento};tipoevento={servico.TipoEvento}; dataevento={servico.DataEvento}; numeroconvidado={servico.NumeroConvidado}; observacoes={servico.Obs};";
        }
    }
}