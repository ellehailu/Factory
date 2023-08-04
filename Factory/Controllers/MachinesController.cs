using Factory.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}
