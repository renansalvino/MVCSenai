using Microsoft.AspNetCore.Mvc;
using MVC2.ViewModels;


namespace MVC2.Controllers
{
    public class ProgramaçãoController : AbstractController
    {
               public IActionResult Index()
        {

           
            
            return View(new BaseViewModel()
            {
                NomeView = "programação",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),

            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}