using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TreinoMVC.Models;
using TreinoMVC.Data;
using TreinoMVC.DTO;

namespace TreinoMVC.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }


        private readonly ApplicationDbContext database;

        public HomeController(ApplicationDbContext database){
            this.database = database;
        }


        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Categorias (){
          return View();
        }  
         public IActionResult NovaCategoria (){
          return View();
        }  

         public IActionResult Contatos (){
         return View();
        }  



        public IActionResult NovoContato (){
          ViewBag.Categorias = database.Categorias.ToList();
          return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
