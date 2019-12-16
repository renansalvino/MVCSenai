using Microsoft.AspNetCore.Mvc;
using MVC2.ViewModels;


namespace MVC2.Controllers
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