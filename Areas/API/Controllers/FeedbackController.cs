using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication3.Infrastructure.Data;
using MvcApplication3.Models;

namespace MvcApplication3.Areas.API.Controllers
{
    public class FeedbackController : Controller
    {
        private FeedbackContext db = new FeedbackContext();
        
        public ActionResult Index()
        {
            List<Feedback> results = null;
            if (!Request.QueryString.AllKeys.Contains("url")){
                results = db.FeedbackItems.ToList();
            } else {
                var url = Request.QueryString["url"];
                results = db.FeedbackItems.Where(x => x.URL == url).ToList();
            }

            var json = Json(results);
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return json;
        }

        public ActionResult Count()
        {
            int results = 0;
            if (!Request.QueryString.AllKeys.Contains("url"))
            {
                results = db.FeedbackItems.Count();
            }
            else
            {
                var url = Request.QueryString["url"];
                results = db.FeedbackItems.Count(x => x.URL == url);
            }

            var json = Json(results);
            json.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return json;
        }


        //
        // GET: /API/Feedback/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /API/Feedback/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /API/Feedback/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /API/Feedback/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /API/Feedback/Edit/5

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
        // GET: /API/Feedback/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /API/Feedback/Delete/5

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
