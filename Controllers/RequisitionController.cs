using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrixtonLab.Controllers
{
    public class RequisitionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NewIdLisReq()
        {
            return View();
        }
        public IActionResult IdReqReport()
        {
            return View();
        }
        public IActionResult BloodReqLis()
        {
            return View();
        }
    }
}
