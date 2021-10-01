using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication33.Controllers
{
    public class DController : Controller
    {
        // GET: D
        public ActionResult Index()
        {
            return View();
        }

        // GET: D/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: D/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: D/Create
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

        // GET: D/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: D/Edit/5
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

        // GET: D/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: D/Delete/5
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
