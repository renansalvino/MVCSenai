﻿using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers {
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