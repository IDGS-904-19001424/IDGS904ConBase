using IDGS904ConBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ConBase.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Alumnos.ToList());
            }
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Alumnos.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumno alumno)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    dbAlumno.Alumnos.Add(alumno);
                    dbAlumno.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(alumno);
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Alumnos/Edit/5
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

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Alumnos/Delete/5
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
