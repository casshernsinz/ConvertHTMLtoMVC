using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConvertHTMLtoMVC.Controllers
{
    public class HomeController : Controller
    {
        //This action is used to render the content from index.html
        public ActionResult Index()
        {
            return View();
        }

        //New action to render content from HTML.html
        public ActionResult HTML()
        {
            return View();
        }

        //New action to render content from CSS.html
        public ActionResult CSS()
        {
            return View();
        }

        //New action to render content from Resources/index.html
        public ActionResult Resources()
        {
            return View();
        }

        //New action to render content from css_topics/fonts.html
        public ActionResult Fonts()
        {
            return View();
        }
       

        //New action to render content from css_topics/colors.html
        public ActionResult Colors()
        {
            return View();
        }

        //New action to render content from css_topics/Images.html
        public ActionResult Images()
        {
            return View();
        }
    }
}