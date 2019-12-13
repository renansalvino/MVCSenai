using System;

namespace RoleTopMVC.Models {

    public class Cliente {
        public uint Id {get;set;}
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
        public uint TipoUsuario { get; set; }

        public Cliente () {
            Cliente cliente = new Cliente();

        }
        public Cliente (string nome, string telefone, string senha, string email, string CPF, DateTime dataNascimento) {

            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = CPF;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.TipoUsuario = 0; //Pendente

        }

    }
}