using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Contoso.DotNetBoilerplate.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
