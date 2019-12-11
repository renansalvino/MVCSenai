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
                Pedido pedido = new Pedido ();
                pedido.Cliente.Nome = ExtrairValorDoCampo ("nome", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo ("number", linha);
                pedido.Cliente.Email = ExtrairValorDoCampo ("email", linha);
                pedido.NomeEvento = ExtrairValorDoCampo ("NomeEvento", linha);
                pedido.TipoEvento = ExtrairValorDoCampo ("tipoevento", linha);
                pedido.DataEvento = DateTime.Parse (ExtrairValorDoCampo ("dataevento", linha));
                pedido.NumeroConvidado = int.Parse (ExtrairValorDoCampo ("numeroconvidado", linha));
                pedido.Obs = ExtrairValorDoCampo ("observacoes", linha);
                pedido.Cliente.Telefone = ExtrairValorDoCampo ("number", linha);
                pedido.Status = uint.Parse (ExtrairValorDoCampo ("status_pedido", linha));
                pedido.Id = ulong.Parse (ExtrairValorDoCampo ("id", linha));
                servicos.Add (pedido);
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
            Cliente cliente = servico.Cliente;
            return $"nome={cliente.Nome};number={cliente.Telefone};email={cliente.Email};id={pedido.Id};status_pedido={pedido.Status};NomeEvento={servico.NomeEvento};tipoevento={servico.TipoEvento};dataevento={servico.DataEvento};numeroconvidado={servico.NumeroConvidado};observacoes={servico.Obs};";
        }
    }
}