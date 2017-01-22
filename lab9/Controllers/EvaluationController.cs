using lab9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab9.Controllers
{
    public class EvaluationController : Controller
    {

        public ActionResult Index(string searchTerm = null)
        {
            if (searchTerm != null)
            {
                var lowerSearchTerm = searchTerm.ToLower();
                var model = ListofProjects.Where(p => p.name.ToLower().StartsWith(lowerSearchTerm)).Take(10);
            }
            return View();

        }

        // GET: Evaluation
        //  public ActionResult Index()
        //  {
        //    return View(ListofProjects);
        // }

        // GET: Evaluation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Evaluation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evaluation/Create
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

        // GET: Evaluation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Evaluation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            
            
                // TODO: Add update logic here

                var evaluation = ListofProjects.Single(e => e.id == id);

                if (TryUpdateModel(evaluation))
                {
                    return RedirectToAction("Index");
                }
                return View(evaluation);
            }
        //public ActionResult Save(int id, FormCollection collection) {
        //    var evaluation = listOfProject.Single(e => e.Id == id);
        //    if (TryUpdateModel(evaluation))
        //    { return RedirectToAction("Index"); }
        //    return View(evaluation);
        //}

        // GET: Evaluation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Evaluation/Delete/5
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

        public static List<ProjectEvaluation> ListofProjects = new List<ProjectEvaluation>()
        {
            new ProjectEvaluation() {

                city="<script>alert('xss');</script>",
                name="Cluj-Napoca Proj",
                country="Romania",
                rating=10,
                id=100,

    },
            new ProjectEvaluation()
            {
                city="Iasi",
                name="IasiProj",
                country="Romania",
                rating=10,
                id=101,
            },
            new ProjectEvaluation()
            {
                city="Suceava",
                name="Sv Proj",
                country="Romania",
                rating=10,
                id=102
            }
           
        };
    }
}
    
    

