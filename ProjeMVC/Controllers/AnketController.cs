using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.DesignPatterns.GenericRepository.ConcRepo;
using Project.ENTITIES;
using ProjeMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeMVC.Controllers
{
    public class AnketController : Controller
    {
        IAnketRepository _repository;

        public AnketController(IAnketRepository repository)
        {
            _repository = repository;
        }
        // GET: AnketController
        public ActionResult Index()
        {
            List<AnketViewModel> model = new List<AnketViewModel>();

            List<Anket> liste = _repository.List();

            foreach (Anket item in liste)
            {
                AnketViewModel awm = new AnketViewModel()
                {
                    Id = item.Id,
                    SoruTipi = item.SoruTipi,
                    PersonelYorumu = item.PersonelYorumu,
                    IsAnonymous=item.IsAnonymous
                };

                model.Add(awm);
            }
            return View(model);

        }

        // GET: AnketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnketController/Create
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

        // GET: AnketController/Edit/5
        public ActionResult Edit(int? id)
        {
            AnketViewModel model = new AnketViewModel();
            
            if (id.HasValue && id > 0)
            {
                Anket ank = _repository.GetById(id.Value);

                model.Id = ank.Id;
                model.SoruTipi = ank.SoruTipi;
                model.PersonelYorumu = ank.PersonelYorumu;
                model.IsAnonymous = ank.IsAnonymous;
            }

            return View(model);
        }

        // POST: AnketController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AnketViewModel model)
        {
            Anket entity = new Anket()
            {

                Id = model.Id,
                SoruTipi = model.SoruTipi,
                PersonelYorumu = model.PersonelYorumu,
                IsAnonymous = model.IsAnonymous
            };
            if (entity.Id > 0)
            {
                _repository.Update(entity);
            }
            else
            {
                _repository.Add(entity);
            }
            return RedirectToAction("Index");
        }

        // GET: AnketController/Delete/5
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: AnketController/Delete/5
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
