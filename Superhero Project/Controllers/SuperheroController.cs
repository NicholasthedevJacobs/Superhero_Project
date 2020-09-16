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
            List<Superhero> superheroes = context.Superheroes.ToList();
            return View(superheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = context.Superheroes.Where(s => s.Id == id).Single();
            return View(id);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            try
            {
                Superhero superhero = new Superhero();
                return View(superhero);
            }
            catch
            {
                return RedirectToAction("Index");
            }
            
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
        public ActionResult Edit(int id)
        {
            //put into try catch
            try
            {
                Superhero superhero = context.Superheroes.Where(s => s.Id == id).Single();
                return View(superhero);
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here 
                Superhero superhero1 = context.Superheroes.Where(s => s.Id == id).Single();
                superhero1.Name = superhero.Name;
                superhero1.PrimaryAbility = superhero.PrimaryAbility;
                superhero1.SecondaryAbility = superhero.SecondaryAbility;
                superhero1.AlterEgo = superhero.AlterEgo;
                superhero1.Catchphrase = superhero.Catchphrase;

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
            try
            {
                Superhero superhero = context.Superheroes.Where(s => s.Id == id).Single();
                return View(superhero);
            }
            catch
            {
                return View(id);
            }
           
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                
                superhero = context.Superheroes.Where(s => s.Id == id).Single();
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
