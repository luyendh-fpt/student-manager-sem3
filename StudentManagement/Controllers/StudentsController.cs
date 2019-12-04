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
        //public ActionResult Index(int? page, int? limit)
        //{
        //    if (page == null)
        //    {
        //        page = 1;
        //    }

        //    if (limit == null)
        //    {
        //        limit = 10;
        //    }

        //    ViewBag.limit = limit;
        //    var list = db.Students.OrderByDescending(s => s.CreatedAt).ToPagedList(page.Value, limit.Value);
        //    return View(list);
        //}

        public ActionResult Index(int? page, int? limit, string start, string end)
        {
            if (page == null)
            {
                page = 1;
            }

            if (limit == null)
            {
                limit = 10;
            }
            var startTime = DateTime.Now;
            startTime = startTime.AddYears(-1);
            try
            {
                startTime = DateTime.Parse(start);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            var endTime = DateTime.Now;
            try
            {
                endTime = DateTime.Parse(end);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            ViewBag.limit = limit;
            var students = db.Students.OrderByDescending(s => s.CreatedAt).Where(s => s.CreatedAt >= startTime && s.CreatedAt <= endTime);
            ViewBag.TotalPage = Math.Ceiling((double)students.Count() / limit.Value);
            ViewBag.CurrentPage = page;
            ViewBag.Limit = limit;
            ViewBag.Start = startTime.ToString("yyyy-MM-dd");
            ViewBag.End = endTime.ToString("yyyy-MM-dd");
            var list = students.Skip((page.Value - 1) * limit.Value).Take(limit.Value).ToList();
            return View("IndexPaginate", list);
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