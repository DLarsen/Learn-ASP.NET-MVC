using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Models;
using MvcApplication3.Infrastructure.Data;

namespace MvcApplication3.Controllers
{
    public class FeedbackController : Controller
    {
        private FeedbackContext db = new FeedbackContext();
        
        //
        // GET: /Feedback/
        public ActionResult Index()
        {
            return View(db.FeedbackItems.ToList());
        }

        //
        // GET: /Feedback/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Feedback/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Feedback/Create

        [HttpPost]
        public ActionResult Create(Feedback item)
        {
            try
            {
                item.Created = DateTime.Now;
                db.FeedbackItems.Add(item);
                db.SaveChanges();

                if (Request.IsAjaxRequest()) {
                    return Json(new { success = true });
                }
                else {
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Feedback/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Feedback/Edit/5

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
        // GET: /Feedback/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Feedback/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
