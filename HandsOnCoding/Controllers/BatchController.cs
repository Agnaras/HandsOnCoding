using HandsOnCoding.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnCoding.Controllers
{
    public class BatchController : Controller
    {

        private IBatch _repo;
        public BatchController(IBatch repo)
        {
            _repo = repo;
        }
        // GET: BatchController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BatchController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult CourseBatchDetails()
        {
            return View(_repo.GetCourseBatchDetails());
        }

        // GET: BatchController/Create
        public ActionResult Create()
        {
            ViewBag.CourseName = _repo.GetAllCourses();
            return View();
        }

        // POST: BatchController/Create
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

        // GET: BatchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BatchController/Edit/5
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

        // GET: BatchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BatchController/Delete/5
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
