using System.Linq;
using System.Web.Mvc;
using MvcApplicationCustomModelBinder.Models;

namespace MvcApplicationCustomModelBinder.Controllers
{
    public class QuestionController : Controller
    {
        private readonly QuestionsContext db;

        public QuestionController(QuestionsContext context)
        {
            db = context;
        }

        //
        // GET: /Question/

        public ActionResult Index()
        {
            return View(db.Questions.Include("Category"));
        }

        //
        // GET: /Question/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Questions.Find(id));
        }

        //
        // GET: /Question/Create

        public ActionResult Create()
        {
            ViewBag.Categories = db.Categories.ToList().Select(option => new SelectListItem
            {
                Text = option.CategoryName,
                Value = option.CategoryId.ToString()
            });
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question question)
        {
            if (ModelState.IsValid)
            {
                db.Questions.Add(question);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(question);
        }

        //
        // GET: /Question/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Question/Edit/5

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

        //
        // GET: /Question/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Question/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.Questions.Remove(db.Questions.Find(id));
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
