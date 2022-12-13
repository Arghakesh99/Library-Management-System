using Library_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_Management_System.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using(lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblCustomer.ToList());
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblCustomer.Where(x => x.Customer_Id == id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(tblCustomer customer)
        {
            try
            {
                using (lmsProjectEntities dbModel = new lmsProjectEntities())
                {
                    dbModel.tblCustomer.Add(customer);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblCustomer.Where(x => x.Customer_Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tblCustomer customer)
        {
            try
            {
                using (lmsProjectEntities dbModel = new lmsProjectEntities())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (lmsProjectEntities dbModel = new lmsProjectEntities())
            {
                return View(dbModel.tblCustomer.Where(x => x.Customer_Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (lmsProjectEntities dbModel = new lmsProjectEntities())
                {
                    tblCustomer customer = dbModel.tblCustomer.Where(x => x.Customer_Id == id).FirstOrDefault();
                    dbModel.tblCustomer.Remove(customer);
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
