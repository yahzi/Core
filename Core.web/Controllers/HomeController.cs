using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.web.Models;
using Core.Lib;
using Core.Lib.Model;

namespace Core.web.Controllers
{
    public class HomeController : Controller
    {
        private DBcontext _dbContext;
        public HomeController(DBcontext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IActionResult Index()
        {
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
        [HttpGet]
        public JsonResult GetUserList()
        {
            
            return Json(new { data = "ok" });
        }
        [HttpGet]
        public JsonResult AddUser()
        {
            Lib.Model.User us = new Lib.Model.User();
            
            //us.UserName = "Xz";
            //us.UserAccount = "xuzhi";
            //us.UserPassword = "123456";

            //_dbContext.User.Add(us);
            //_dbContext.SaveChanges();

            
            return Json(new { data = "ok" });
        }
    }
}
