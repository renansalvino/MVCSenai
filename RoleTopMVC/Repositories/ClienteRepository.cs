using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories {
    public class ClienteRepository : RepositoryBase { // é o cadastro repositorio

        private const string PATH = "Database/Cliente.csv";

        //Criando CSV

        public ClienteRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }

        public bool Inserir (Cliente cliente) {
            var linha = new string[] { PrepararRegistrocsv (cliente) };
            File.AppendAllLines (PATH, linha);
            return true;
        }

        public Cliente ObterPor (string email) {
            var linhas = File.ReadAllLines (PATH);
            foreach (var item in linhas) {
                if (ExtrairValorDoCampo("email", item).Equals(email)) {
                    Cliente cliente = new Cliente ();
                    cliente.Nome = ExtrairValorDoCampo ("nome", item);
                    cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo ("date", item));
                    cliente.Telefone = ExtrairValorDoCampo ("number", item);
                    cliente.CPF = ExtrairValorDoCampo ("CPF", item);
                    cliente.Email = ExtrairValorDoCampo ("email", item);
                    cliente.Senha = ExtrairValorDoCampo ("senha", item);
                    cliente.TipoUsuario = uint.Parse (ExtrairValorDoCampo ("tipo_usuario", item));
                    return cliente;
                }
            }
            return null;
        }

        private string PrepararRegistrocsv (Cliente cliente) {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};date={cliente.DataNascimento};number={cliente.Telefone};CPF={cliente.CPF};email={cliente.Email};senha={cliente.Senha}";
        }
    }
}