﻿using Plants.Web.Controllers;
using Plants.Web.Models.ViewModels;
using Starter.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plants.Web.Controllers
{
    [RoutePrefix("plants")]
    public class PlantsController : BaseController
    {
        public PlantsController() { }

        [Route, HttpGet]
        [Route("{id:int}")]
        public ActionResult Plants(int? id = null)
        {
            ItemsViewModel<Dictionary<string, int>, int?> model = new ItemsViewModel<Dictionary<string, int>, int?>();

            // If model.Items does not exist, instantiate List 
            if (model.Items == null)
            {
                model.Items = new List<Dictionary<string, int>>();
            }

            model.Item = id;
            model.Items.Add(SizeEntities.NotSet.ToDictionaryByName(1));
            model.Items.Add(CategoryEntities.NotSet.ToDictionaryByName(1));

            return View(model);
        }

        [Route("get"), HttpGet]
        public ActionResult Display()
        {
            return View();
        }
    }
}