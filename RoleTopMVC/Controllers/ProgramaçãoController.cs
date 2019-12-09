using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
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