namespace RoleTopMVC.Models
{
    public class Produto 
    {

        public string Nome {get;set;}
        public double Preco {get;set;}



        public Produto (string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public Produto ()
        {
            
        }

    }
}