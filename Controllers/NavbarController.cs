using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Grid.CRUD.Models;
using Kendo.Mvc.Grid.CRUD.Domain;

namespace Kendo.Mvc.Grid.CRUD.Controllers
{
    public class NavbarController : Controller
    {
        // GET: Navbar
        public ActionResult Navbar(string controller, string action)
        {
            var data = new Data();

            var navbar = data.itemsPerUser(controller, action, User.Identity.Name);

            return PartialView("_navbar", navbar);
        }
    }
}