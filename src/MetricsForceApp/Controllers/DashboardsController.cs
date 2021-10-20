using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsForceApp.Controllers
{
    public class DashboardsController : Controller
    {
        // GET: DashboardsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DashboardsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DashboardsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DashboardsController/Create
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

        // GET: DashboardsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DashboardsController/Edit/5
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

        // GET: DashboardsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DashboardsController/Delete/5
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
