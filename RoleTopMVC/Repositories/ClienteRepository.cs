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
                    Cliente c = new Cliente ();
                    c.Nome = ExtrairValorDoCampo ("nome", item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo ("date", item));
                    c.Telefone = ExtrairValorDoCampo ("number", item);
                    c.CPF = ExtrairValorDoCampo ("CPF", item);
                    c.Email = ExtrairValorDoCampo ("email", item);
                    c.Senha = ExtrairValorDoCampo ("senha", item);
                    c.TipoUsuario = uint.Parse (ExtrairValorDoCampo ("tipo_usuario", item));
                    return c;
                }
            }
            return null;
        }

        private string PrepararRegistrocsv (Cliente cliente) {
            return $"tipo_usuario={cliente.TipoUsuario};nome={cliente.Nome};date={cliente.DataNascimento};number={cliente.Telefone};CPF={cliente.CPF};email={cliente.Email};senha={cliente.Senha}";
        }
    }
}