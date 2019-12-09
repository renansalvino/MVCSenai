namespace RoleTopMVC.Models {
    public class Servicos {
        Servicos Servico {get;set;}
        public string Iluminação { get; set; }
        public string Som { get; set; }

        public Servicos(Servicos servico, string iluminacao, string som)
        {
            this.Servico = servico;
            this.Iluminação = iluminacao;
            this.Som = som;
        }
    }
}