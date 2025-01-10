using HandsOnCoding.IRepo;
using HandsOnCoding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnCoding.Controllers
{
    public class CourseTrainingController : Controller
    {
        // GET: CourseTrainingController

        private ICourse _repo;
        public CourseTrainingController(ICourse repo)
        {
            _repo = repo;
        }
        public ActionResult IndexCourse()
        {
            return View(_repo.GetCourses());
        }

        // GET: CourseTrainingController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetCourseById(id));
        }

        // GET: CourseTrainingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseTrainingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                _repo.AddCourse(course);
                return RedirectToAction(nameof(IndexCourse));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseTrainingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetCourseById(id));
        }

        // POST: CourseTrainingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                _repo.UpdateCourse(id, course);
                return RedirectToAction(nameof(IndexCourse));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseTrainingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repo.GetCourseById(id));
        }

        // POST: CourseTrainingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deleted(int id)
        {
            try
            {
                _repo.DeleteCourse(id);
                return RedirectToAction(nameof(IndexCourse));
            }
            catch
            {
                return View();
            }
        }
    }
}
