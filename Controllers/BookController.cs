using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_Management_System.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Library_Management_System.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblBook.ToList());
            }
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblBook.Where(x => x.Book_Id == id).FirstOrDefault());
            }
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(tblBook book)
        {
            try
            {
                using (lmsProjectEntities dbModel = new lmsProjectEntities())
                {
                    dbModel.tblBook.Add(book);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblBook.Where(x => x.Book_Id == id).FirstOrDefault());
            }
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tblBook book)
        {
            try
            {
                using (lmsProjectEntities dbModel = new lmsProjectEntities())
                {
                    dbModel.Entry(book).State = EntityState.Modified;
                    dbModel.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblBook.Where(x => x.Book_Id == id).FirstOrDefault());
            }
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (lmsProjectEntities dbModel = new lmsProjectEntities())
                {
                    tblBook book = dbModel.tblBook.Where(x => x.Book_Id == id).FirstOrDefault();
                    dbModel.tblBook.Remove(book);
                    dbModel.SaveChanges();

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
