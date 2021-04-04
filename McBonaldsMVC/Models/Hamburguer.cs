using Microsoft.Extensions.Primitives;

namespace Hamburgueria_WebMVC.Models {
    public class Hamburguer : Produto {
        public Hamburguer(StringValues Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public Hamburguer() // CONTRUTOR VAZIO, NÃO REMOVE-LO
        {
        }
    }
}