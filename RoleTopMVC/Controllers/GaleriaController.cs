using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.Models;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {

            
            return View(new BaseViewModel(){
                    NomeView = "galeria",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession (),
            }
            );
        }

        
    }
}