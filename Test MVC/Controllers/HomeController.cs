using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }       

        [HttpPost]
        public ActionResult Login(string uname, string pswd)
        {
            List<LoginClass> listOfValidUsers = new List<LoginClass>
        {
            new LoginClass { LogID = 1,Username="David",Password="123" },
            new LoginClass{LogID =2,Username="Kevin",Password="abc"}
        };

            if (ModelState.IsValid)
            {
                var r = from user in listOfValidUsers
                        where user.Username.Trim() == uname.Trim() && user.Password.Trim() == pswd
                        select user;
                if (r.Count() > 0)
                {
                    ViewData["Message"] = "Success";

                }
                else
                {
                    ViewData["Message"] = "Fail";
                }
            }
            return View("Index1");
        }

    }
    public class LoginClass
    {
        public int LogID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }

}