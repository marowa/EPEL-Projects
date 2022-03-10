using EPEL_Projects.Models;
using EPEL_Projects.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Controllers
{
    public class GovernorateController : Controller
    {
        GovernorateService GovernorateSer = new GovernorateService();

        public IActionResult Index()
        {
            //List<Governorate> governments = GovernorateSer.selectAllGovernments(15);
            ViewBag.Govs = GovernorateSer.selectAllGovernments(15);
            return View("Index");
        }

        [HttpPost]
        public IActionResult InsertGovernment(int id, Governorate gov)
        {
            GovernorateSer.insertGovernment(gov);
            return RedirectToAction("Index");
                
        }

        public IActionResult DeleteGovernment(int id,Governorate gov)
        {
            GovernorateSer.deleteGovernment(id,gov);
            return RedirectToAction("Index");
        }

        //public IActionResult InsertGovernment()
        //{
        //    return View("Insert");
        //}
        //public IActionResult saveInsertGovernment(int id, Governorate gov)
        //{
        //    GovernorateSer.Insert(gov);
        //    return RedirectToAction("Index");
        //}

        //public IActionResult edit(int id)
        //{
        //    Governorate gov = GovernorateSer.selectGovernmentByID(id);
        //    return View(gov);
        //}
        //public IActionResult saveEdit(int id, Governorate gov)
        //{
        //    GovernorateSer.Edit(gov);
        //    return RedirectToAction("Index");
        //}
    }
}
