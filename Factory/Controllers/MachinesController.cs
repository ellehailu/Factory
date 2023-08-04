using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;
using System.Collections.Generic;

namespace Factory.Controllers
{
    public class MachinesController : Controller
    {
        private readonly FactoryContext _db;

        public MachinesController(FactoryContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            // List<Machine> model = _db.Machines.ToList();
            // return View(model);
            return View();
        }
    }
}
