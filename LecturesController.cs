using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Controllers {
    public class LecturesController : Controller {
        
        // GET: Lectures
        public ActionResult Index() {
            try {
                var id = HttpContext.Request.RequestContext.RouteData.Values["id"];
                string sid = (string)id;

                if (sid.Contains("any"))
                    return View("any name");
                if (sid.Contains("copy"))
                    return View("any name - Copy");
                else
                    return View();

            } catch (Exception) {

                return View();
               // throw;
            }
           
        }

        // POST: Lectures
        [HttpPost]
        public ActionResult Index(int i) {
            return View();
        }
    }
}
