using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using WUDIF.DAL;
using WUDIF.Models;
using WUDIF.Repositories;

namespace WUDIF.Controllers
{
    public class QuestionsController : Controller
    {

        // Property of the type IRepository <TEnt, in TPk>
        private IRepository<Question, int> _repository;

        // Constructer - The Dependency Injection of the IRepository
        public QuestionsController(IRepository<Question, int> repo)
        {
            _repository = repo;
        }

        private MainDBContext db = new MainDBContext();

        // GET: Questions
        public ActionResult Index()
        {
            var quest = _repository.Get();
            return View(quest);
        }

        // GET: Questions/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = _repository.Get(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // GET: Questions/Create
        [Authorize]
        public ActionResult Create()
        {
            var Quest = new Question();
            return View(Quest);
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "AddUser,AddDate,QuestionID,QuestionContent")] Question question)
        {
            if (ModelState.IsValid)
            {
               

                _repository.Add(question);
                return RedirectToAction("Index");
            }

            return View(question);
        }

        // GET: Questions/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Question question = _repository.Get(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "AddUser,AddDate,QuestionID,QuestionContent")] Question question)
        {
            if (ModelState.IsValid)
            {
                
                db.Entry(question).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(question);
        }

        // GET: Questions/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            Question question = _repository.Get(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
