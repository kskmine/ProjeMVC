using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DesignPatterns.GenericRepository.ConcRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeMVC.Controllers
{
    public class PersonelController : Controller
    {
        IPersonelRepository _repository;

        public PersonelController(IPersonelRepository repository)
        {
            _repository = repository;
        }
        // GET: PersonelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
