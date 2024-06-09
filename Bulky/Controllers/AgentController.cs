using Bulky.Data;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bulky.Controllers
{
    public class AgentController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AgentController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Agent> objAgentList = _db.Agents.ToList();

            return View(objAgentList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Agent obj)
        {
            if ((obj.Name) == obj.Number.ToString())
            {
                ModelState.AddModelError("Name", "Category Name and Display Order can not be same");
            }

            if (ModelState.IsValid)
            {
                _db.Agents.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Operador Cadastrado com Sucesso";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
