using MVCWithEFCF1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF1.Controllers
{
    public class CategoryController : Controller
    {
       
       


        #region connection string
        StoredDBContext dc = new StoredDBContext();
        #endregion

        #region  display All Catagory
        public ViewResult DisplayCatagory()
        {
            return View(dc.Categories);
        }
        #endregion

        #region  Add Catagory
        [HttpGet]
        public ViewResult AddCatagory()
        {
            return View();

        }
        [HttpPost]
        public RedirectToRouteResult AddCatagory(Category categories)
        {
            dc.Categories.Add(categories);
           // dc.sav
            dc.SaveChanges();
            return RedirectToAction("DisplayCatagory");

        }

        #endregion

        #region Edit 
        [HttpGet]
        public ViewResult Edit(int cid)
        {
            return View(dc.Categories.Find(cid));
        }
        [HttpPost]
        public RedirectToRouteResult Edit(Category categories)
        {
            dc.Entry(categories).State = EntityState.Modified;
            dc.SaveChanges();

            return RedirectToAction("DisplayCatagory");
        }
        #endregion

        #region delete
        public RedirectToRouteResult DeleteCatagory(int cid)
        {

            dc.Categories.Remove(dc.Categories.Find(cid));

            dc.SaveChanges();
            return RedirectToAction("DisplayCatagory");
        }


        #endregion
    }
}