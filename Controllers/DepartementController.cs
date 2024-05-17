using GestionEnseignants.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GestionEnseignants.Models.Repositories;

namespace GestionEnseignants.Controllers
{
    [Authorize]
    public class DepartementController : Controller
    {
        readonly IDepartementRepository<Departement> departementRepository;
        public DepartementController(IDepartementRepository<Departement> departementRepository)
        {
            this.departementRepository = departementRepository;
        }

        // GET: DepartementController
        public ActionResult Index()
        {
            var Departements = departementRepository.GetAll();
            return View(Departements);
        }

        // GET: DepartementController/Details/5
        public ActionResult Details(int id)
        {
            var departement = departementRepository.GetById(id);
            return View(departement);

        }

        // GET: DepartementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Departement departement)
        {
            try
            {
                departementRepository.Add(departement);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartementController/Edit/5
        public ActionResult Edit(int id)
        {
            var departement = departementRepository.GetById(id);
            return View(departement);
        }

        // POST: DepartementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Departement departement)
        {
            try
            {
                departementRepository.Edit(departement);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartementController/Delete/5
        public ActionResult Delete(int id)
        {
            var departement = departementRepository.GetById(id);
            return View(departement);
        }

        // POST: DepartementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Departement departement)
        {
            try
            {
                departementRepository.Delete(departement);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
