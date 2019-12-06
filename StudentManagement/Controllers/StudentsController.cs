using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult GetChartData(string start, string end)
        {
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
            startTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, 0, 0, 0, 0);

            var endTime = DateTime.Now;
            try
            {
                endTime = DateTime.Parse(end);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            endTime = new DateTime(endTime.Year, endTime.Month, endTime.Day, 23, 59, 59, 0);

            var data = db.Students.Where(s => s.Status != Student.StudentStatus.Deleted && (s.CreatedAt >= startTime && s.CreatedAt <= endTime))
                .GroupBy(
                    s => new
                    {
                        Year = s.CreatedAt.Year,
                        Month = s.CreatedAt.Month,
                        Day = s.CreatedAt.Day
                    }
                ).Select(s => new
                {
                    Date =  s.FirstOrDefault().CreatedAt,
                    Count = s.Count()
                }).OrderBy(s => s.Date).ToList();
            return new JsonResult()
            {
                Data = data.Select(s=> new
                {
                    Date = s.Date.ToString("MM/dd/yyyy"),
                    Count = s.Count
                }),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

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