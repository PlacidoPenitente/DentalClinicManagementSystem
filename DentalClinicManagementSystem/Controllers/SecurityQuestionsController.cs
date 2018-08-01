namespace DentalClinicManagementSystem.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using DentalClinicManagementSystem.Models;

    public class SecurityQuestionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SecurityQuestions
        public async Task<ActionResult> Index()
        {
            return View(await db.SecurityQuestions.ToListAsync());
        }

        // GET: SecurityQuestions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityQuestion securityQuestion = await db.SecurityQuestions.FindAsync(id);
            if (securityQuestion == null)
            {
                return HttpNotFound();
            }
            return View(securityQuestion);
        }

        // GET: SecurityQuestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecurityQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Question,DateAdded,DateModified,Status")] SecurityQuestion securityQuestion)
        {
            if (ModelState.IsValid)
            {
                securityQuestion.DateAdded = DateTime.Now;
                securityQuestion.DateModified = DateTime.Now;
                db.SecurityQuestions.Add(securityQuestion);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(securityQuestion);
        }

        // GET: SecurityQuestions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityQuestion securityQuestion = await db.SecurityQuestions.FindAsync(id);
            if (securityQuestion == null)
            {
                return HttpNotFound();
            }
            return View(securityQuestion);
        }

        // POST: SecurityQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Question,DateAdded,DateModified,Status")] SecurityQuestion securityQuestion)
        {
            if (ModelState.IsValid)
            {
                securityQuestion.DateModified = DateTime.Now;
                db.Entry(securityQuestion).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(securityQuestion);
        }

        // GET: SecurityQuestions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecurityQuestion securityQuestion = await db.SecurityQuestions.FindAsync(id);
            if (securityQuestion == null)
            {
                return HttpNotFound();
            }
            return View(securityQuestion);
        }

        // POST: SecurityQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SecurityQuestion securityQuestion = await db.SecurityQuestions.FindAsync(id);
            db.SecurityQuestions.Remove(securityQuestion);
            await db.SaveChangesAsync();
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
