using IDGS904ConBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ConBase.Controllers
{
    public class MaestroController : Controller
    {
        // GET: Maestro
        public ActionResult Index()
        {
            using (var dbMaestro = new AlumnoContext())
            {
                return View(dbMaestro.Maestros.ToList());
            }
        }

        // GET: Maestro/Details/5
        public ActionResult Details(int id)
        {
            using (var dbMaestro = new AlumnoContext())
            {
                return View(dbMaestro.Maestros.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Maestro/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Maestro maestro)
        {
            try
            {
                using (var dbMaestro = new AlumnoContext())
                {
                    dbMaestro.Maestros.Add(maestro);
                    dbMaestro.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(maestro);
            }
        }

        // GET: Maestro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Maestro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Maestro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
