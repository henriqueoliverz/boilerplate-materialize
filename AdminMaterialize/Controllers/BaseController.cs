using AdminMaterialize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminMaterialize.Controllers
{
    public class BaseController : Controller
    {
        public List<Breadcrumb> Breadcrumbs { get; set; }
        public string Titulo { get; set; }

        public BaseController()
        {
            ViewBag.Breadcrumbs = Breadcrumbs;
            ViewBag.Titulo = Titulo;
        }
    }
}