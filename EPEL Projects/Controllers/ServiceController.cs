using EPEL_Projects.Models;
using EPEL_Projects.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Controllers
{
    public class ServiceController : Controller
    {
        ServiceService serviceSer = new ServiceService();
        public IActionResult Index()
        {
            ViewBag.services = serviceSer.SelectAllService();
            return View("Index");
        }
        public IActionResult selectServiceByServiceID(int id)
        {
            Service service = serviceSer.SelectServiceByServiceID(id);
            return View("Index", service);
        }
    }
}
