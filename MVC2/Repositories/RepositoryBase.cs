namespace MVC2.Repositories
{
    public class RepositoryBase
    {
            protected string ExtrairValorDoCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var inicioNome = linha.IndexOf (chave);

            var fimNome = linha.IndexOf (';', inicioNome);

            var valor = "";

            if (fimNome != -1) {
                valor = linha.Substring (inicioNome, fimNome - inicioNome);

            } else {
                valor = linha.Substring (inicioNome);
            }
            System.Console.WriteLine ($"Campo {nomeCampo} e valor{valor}");
            return valor.Replace (nomeCampo + "=", "");
        }
    }
}