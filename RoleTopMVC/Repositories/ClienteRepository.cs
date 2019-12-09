using System;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories {
    public class ClienteRepository : RepositoryBase {

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
                if (ExtrairValorDoCampo ("email", item).Equals (email)) {
                    Cliente cliente = new Cliente ();
                    cliente.Nome = ExtrairValorDoCampo ("nome", item);
                    cliente.DataNascimento = DateTime.Parse(ExtrairValorDoCampo ("dataNascimento", item));
                    cliente.Telefone = ExtrairValorDoCampo ("number", item);
                    cliente.CPF = ExtrairValorDoCampo ("cpf", item);
                    cliente.Email = ExtrairValorDoCampo ("cemail", item);
                    cliente.Senha = ExtrairValorDoCampo ("cesenha", item);

                    return cliente;
                }
            }
            return null;
        }

        private string PrepararRegistrocsv (Cliente cliente) {
            return $"nome={cliente.Nome}; dataNascimento={cliente.DataNascimento}; number={cliente.Telefone}; cpf={cliente.CPF}; cemail={cliente.Email};csenha={cliente.Senha}";
        }
    }
}