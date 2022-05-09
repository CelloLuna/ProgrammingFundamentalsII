using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_with_Bootstrap.Models;

namespace CRUD_with_Bootstrap.Controllers
{
    public class HomeController : Controller
    {
        UniversityEntities1 db = new UniversityEntities1();
        public ActionResult EnrollmentData()
        {
            List<Enrollment> enr = db.Enrollments.ToList();
            return View(enr);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]

        public ActionResult Create(Enrollment enroll)
        {
            try
            {
                if (enroll != null)
                {
                    Enrollment enrollData = new Enrollment();
                    enrollData.Name = enroll.Name;
                    enrollData.Course = enroll.Course;

                    db.Enrollments.Add(enrollData);
                    db.SaveChanges();
                }
                return RedirectToAction("EnrollmentData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occured.";
                return RedirectToAction("EnrollmentData");
            }
        }
    }
}