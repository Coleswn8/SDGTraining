﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;
using DatabaseSite.Models;
using System.ComponentModel.DataAnnotations;

namespace DatabaseSite.Controllers
{
    public class AjaxTestController : Controller
    {
        private PeopleProDatabaseEntities db = new PeopleProDatabaseEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FirstAjax(string name)
        {

            
            var dep = new Department
            {
                Name = name,
                DepartmentId = db.Departments.Count()
            };

            if(TryValidateModel(dep))
            {

                db.Departments.Add(dep);
                db.SaveChanges();
                return PartialView("~/Views/Shared/Partials/DepartmentPartial.cshtml", dep);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //return Json(dep, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult CreatePrompt()
        {
            return PartialView("~/Views/Shared/Partials/CreateDepartmentPartial.cshtml");
        }
    }
}