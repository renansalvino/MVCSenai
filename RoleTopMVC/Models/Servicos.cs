namespace RoleTopMVC.Models {
    public class Servicos : Produto {
        public string Iluminação { get; set; }
        public string Som { get; set; }

        public Servicos( string iluminacao, string som)
        {
         
            this.Iluminação = iluminacao;
            this.Som = som;
        }

        
    }
}