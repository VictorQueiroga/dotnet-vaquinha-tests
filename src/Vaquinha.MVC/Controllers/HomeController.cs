﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using Vaquinha.Domain;
using System.Threading.Tasks;

namespace Vaquinha.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeInfoService _homeService;
        private readonly ILogger<HomeController> _logger;
        private readonly IToastNotification _toastNotification;

        public HomeController(ILogger<HomeController> logger,
                              IHomeInfoService homeService,
                              IToastNotification toastNotification)
        {
            _logger = logger;
            _homeService = homeService;
            _toastNotification = toastNotification;
        }

        public async Task<IActionResult> Index()
        {
            var homeViewModel =  await _homeService.RecuperarDadosIniciaisHomeAsync();

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
