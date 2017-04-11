using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult StartChat(string nazwa)
        {
            Session["uzytkownik"] = nazwa;
            return View("Chat");
        }
        public ActionResult Chat(string msg)
        {
            Message message = new Message()
            {
            Nazwa = Session["uzytkownik"] as String,
            Czas = DateTime.Now,
            Content = msg
        };
            return PartialView("Message", message);
        }
    }
}