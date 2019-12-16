using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "Cliente_Email";
        protected const string SESSION_CLIENTE_NOME = "Cliente_Nome";
        protected const string SESSION_CLIENTE_TIPO = "Cliente_Tipo";

        protected string ObterUsuarioSession () {
            var usuario = HttpContext.Session.GetString (SESSION_CLIENTE_EMAIL);
            if (!string.IsNullOrEmpty (usuario)) {
                return usuario;
            } else {
                return "";
            }
        }

        protected string ObterUsuarioNomeSession () {
            var NomeUsuario = HttpContext.Session.GetString (SESSION_CLIENTE_NOME);
            if (!string.IsNullOrEmpty (NomeUsuario)) {
                return NomeUsuario;
            } else {
                return "";
            }
        }

        protected string ObterUsuarioTipoSession()
        {
            var nome = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if (!string.IsNullOrEmpty(nome))
            {
                return nome;
            }
            else
            {
                return "";
            }
        }

    }
}