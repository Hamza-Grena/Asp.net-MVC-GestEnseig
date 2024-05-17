using GestionEnseignants.Models;
using GestionEnseignants.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GestionEnseignants.Controllers
{
    [Authorize]
    public class EnseignantController : Controller
    {
        readonly IEnseignantRepository<Enseignant> enseignantRepository; 
        public EnseignantController (IEnseignantRepository<Enseignant> enseignantRepository)
        {
            this.enseignantRepository= enseignantRepository;
        }
        // GET: EnseignantController
        public ActionResult Index()
        {
            var enseignant = enseignantRepository.GetAll();
            return View(enseignant);
        }

        // GET: EnseignantController/Details/5
        public ActionResult Details(int id)
        {
            var enseignant = enseignantRepository.GetById(id);
            return View(enseignant);
        }

        // GET: EnseignantController/Create
        public ActionResult Create()
        {
            //ViewBag.DepartementID = new SelectList(DepartementRepository.GetAll(), "Id","depName");

            return View();
        }

        // POST: EnseignantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Enseignant enseignant)
        {
            try
            {
                enseignantRepository.Add(enseignant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EnseignantController/Edit/5
        public ActionResult Edit(int id)
        {
            var enseignant = enseignantRepository.GetById(id);
            return View(enseignant);
        }

        // POST: EnseignantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Enseignant enseignant)
        {
            try
            {
                enseignantRepository.Edit(enseignant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EnseignantController/Delete/5
        public ActionResult Delete(int id)
        {
            var enseignant = enseignantRepository.GetById(id);
            return View(enseignant);
        }

        // POST: EnseignantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Enseignant enseignant)
        {
            try
            {
                enseignantRepository.Delete(enseignant);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
