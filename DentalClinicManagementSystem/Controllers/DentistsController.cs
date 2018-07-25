using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DentalClinicManagementSystem.Models;

namespace DentalClinicManagementSystem.Controllers
{
    public class DentistsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dentists
        public async Task<ActionResult> Index()
        {
            return View(await db.Dentists.ToListAsync());
        }

        // GET: Dentists/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dentist dentist = await db.Dentists.FindAsync(id);
            if (dentist == null)
            {
                return HttpNotFound();
            }
            return View(dentist);
        }

        // GET: Dentists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dentists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Username,Password,SecurityQuestion1,SecurityQuestion2,SecurityQuestion3,Answer1,Answer2,Answer3,FirstName,MiddleName,LastName,Gender,Birthdate,Nationality,Religion,Address,TelephoneNo,MobileNo,Nickname,DateAdded,DateModified,Status,CommissionRate,Specialization")] Dentist dentist)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(dentist);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dentist);
        }

        // GET: Dentists/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dentist dentist = await db.Dentists.FindAsync(id);
            if (dentist == null)
            {
                return HttpNotFound();
            }
            return View(dentist);
        }

        // POST: Dentists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Username,Password,SecurityQuestion1,SecurityQuestion2,SecurityQuestion3,Answer1,Answer2,Answer3,FirstName,MiddleName,LastName,Gender,Birthdate,Nationality,Religion,Address,TelephoneNo,MobileNo,Nickname,DateAdded,DateModified,Status,CommissionRate,Specialization")] Dentist dentist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dentist).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dentist);
        }

        // GET: Dentists/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dentist dentist = await db.Dentists.FindAsync(id);
            if (dentist == null)
            {
                return HttpNotFound();
            }
            return View(dentist);
        }

        // POST: Dentists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Dentist dentist = await db.Dentists.FindAsync(id);
            db.Users.Remove(dentist);
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
