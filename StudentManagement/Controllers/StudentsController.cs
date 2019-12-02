using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentsController : Controller
    {
        private MyContext db = new MyContext();
        // GET: Students
        public ActionResult Index(int? page, int? limit)
        {
            if (page == null)
            {
                page = 1;
            }

            if (limit == null)
            {
                limit = 10;
            }

            ViewBag.limit = limit;
            var list = db.Students.OrderByDescending(s => s.CreatedAt).ToPagedList(page.Value, limit.Value);
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Store(Student student)
        {
            student.CreatedAt = DateTime.Now;
            student.UpdatedAt = DateTime.Now;
            db.Students.Add(student);
            db.SaveChanges();
            TempData["message"] = "Action success!";
            return RedirectToAction("Index");
        }
    }
}