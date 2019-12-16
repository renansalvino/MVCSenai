using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC2.Models;
using MVC2.ViewModels;

namespace MVC2.Controllers {
    public class HomeController : AbstractController {
        public IActionResult Index () {
            return View (new BaseViewModel () {
                NomeView = "Home",
                    UsuarioEmail = ObterUsuarioSession (),
                    UsuarioNome = ObterUsuarioNomeSession (),

            });
        }
        public IActionResult Privacy () {
            return View ();
        }

    }
}