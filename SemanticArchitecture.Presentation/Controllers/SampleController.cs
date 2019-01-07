using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SemanticArchitecture.Application.Application_Services_Interfaces;
using SemanticArchitecture.Domain.Core.Domain_Entities;

namespace SemanticArchitecture.Presentation.Controllers
{
    public class SampleController : Controller
    {
        private ISampleApplicationService _sampleApplicationService;

        public SampleController(ISampleApplicationService sampleApplicationService)
        {
            _sampleApplicationService = sampleApplicationService;
        }

        public ActionResult Index()
        {
            var samples = _sampleApplicationService.GetAll();
            return View(samples);
        }

        public ActionResult Details(Guid id)
        {
            var sample = _sampleApplicationService.GetById(id);
            return View(sample);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sample sample)
        {
            try
            {
                _sampleApplicationService.Add(sample);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return View();
            }
        }

        public ActionResult Edit(Guid id)
        {
            var sample = _sampleApplicationService.GetById(id);
            return View(sample);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sample sample)
        {
            try
            {
                _sampleApplicationService.Update(sample);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(Guid id)
        {
            var sample = _sampleApplicationService.GetById(id);
            return View(sample);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                var sample = _sampleApplicationService.GetById(id);
                _sampleApplicationService.Remove(sample);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}