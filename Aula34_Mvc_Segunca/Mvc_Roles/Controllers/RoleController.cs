using Microsoft.AspNet.Identity.EntityFramework;
using Mvc_Roles.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Mvc_Roles.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Role
        public ActionResult Index()
        {
            List<IdentityRole> role = context.Roles.ToList();
      
            return View(role);
        }

        public ActionResult Create()
        {
            IdentityRole role = new IdentityRole();
            return View(role);
        }

        public ActionResult Create(IdentityRole role)
        {
            context.Roles.Add(role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}