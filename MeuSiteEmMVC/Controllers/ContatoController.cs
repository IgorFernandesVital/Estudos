﻿using Microsoft.AspNetCore.Mvc;

namespace MeuSiteEmMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CriarContato()
        {
            return View();
        }
        public IActionResult EditarContato()
        {
            return View();
        }
        public IActionResult ApagarContato()
        {
            return View();
        }
    }
}
