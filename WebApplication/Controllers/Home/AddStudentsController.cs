using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers.Home
{
    public class AddStudentsController : Controller
    {
        Wep_TestoingEntities db = new Wep_TestoingEntities();

        // GET: AddStudents
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: AddStudents/Details/5
        public ActionResult Details(int id)
        {
            var personId = db.Students.Find(id);

            return View(personId);
        }

        // GET: AddStudents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddStudents/Create
        [HttpPost]
        public ActionResult Create(Student ST)
        {
            try
            {
                Student ss = new Student
                {
                    StuderntName = ST.StuderntName,
                    Student_Phone = ST.Student_Phone,
                    Student_age = ST.Student_age,
                    Student_address = ST.Student_address,

                };
                db.Students.Add(ss);
                db.SaveChanges();
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");

        }

        // GET: AddStudents/Edit/5
        public ActionResult Edit(int id)
        {
            var personId = db.Students.Find(id);

            return View(personId);
        }

        // POST: AddStudents/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Student ST)
        {
            try
            {
                var personId = db.Students.Find(id);

                personId.StuderntName = ST.StuderntName;
                    personId. Student_Phone = ST.Student_Phone;
                    personId.Student_age = ST.Student_age;
                    personId.Student_address = ST.Student_address;
                
                
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddStudents/Delete/5
        public ActionResult Delete(int id)
        {
            var personId = db.Students.Find(id);

            return View(personId);
        }

        // POST: AddStudents/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Student ST)
        {
            try
            {
                // TODO: Add delete logic here
                var personId = db.Students.Find(id);
                Student ss = new Student
                {

                    IS_Deleted = ST.IS_Deleted == false
                };
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
