using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcBoot.Models;
using WebMvcBoot.Repository;

namespace WebMvcBoot.Controllers
{
    public class BaseController<M, R> : Controller where M:BaseModels where R : BaseRepository<M>
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}