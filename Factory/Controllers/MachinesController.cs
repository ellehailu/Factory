using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace MachinesController.Controllers
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
            return View();
        }

        public ActionResult Create(){
            return View();
        }
    }
}
