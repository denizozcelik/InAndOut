using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }

        public   IActionResult Details(int Id)
        {
            return Ok($"You have entered IDDDD = {Id}");
        }

    }
}
