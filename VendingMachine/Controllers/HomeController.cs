using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendingMachine.Models;
using VendingMachine.Services;


namespace VendingMachine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult InsertCoin(double coin)
        {
            
            var amount = new Random().Next(1, 4);
            CustomerSession customerSession = new CustomerSession();

            switch(amount){

                case 1:
                    customerSession.Wallet += 0.05;
                    break;

                case 2:
                    customerSession.Wallet += 0.10;
                    break;

                case 3:
                    customerSession.Wallet += 0.25;
                    break;

                case 4:
                    Console.WriteLine("We do not accept this coin!");
                    break;

            }

            return View("Vend");
        }
    }
}
