using Superhero_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superhero_Project.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext context;

        public SuperheroController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Superhero
        public ActionResult Index()
        {
            return View();
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                context.Superheroes.Add(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(superhero);
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(Superhero id)
        {
            
            return View(id);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(Superhero id, Superhero superhero )
        {
            try
            {
                // TODO: Add update logic here               
                context.Superheroes.AddOrUpdate(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            return View(id);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                context.Superheroes.Remove(superhero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
