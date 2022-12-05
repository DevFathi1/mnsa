using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers.StudentList
{
    public class StudentListController : Controller
    {
        // GET: StudentList
        Wep_TestoingEntities db = new Wep_TestoingEntities();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: StudentList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentList/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentList/Edit/5
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

        // GET: StudentList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentList/Delete/5
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
