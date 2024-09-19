using Microsoft.AspNetCore.Mvc;
using PullaiahgariTicketSales.Models;
using System.Diagnostics;

namespace PullaiahgariTicketSales.Controllers
{
    public class HomeController : Controller
    {
        //Created by Pullaiahhgari
        //6666666

        public IActionResult Index()
        {
            return View();
        }//index

        public IActionResult About()
        {
            return View();
        }//about

    }//homecontroller
}//namespace
