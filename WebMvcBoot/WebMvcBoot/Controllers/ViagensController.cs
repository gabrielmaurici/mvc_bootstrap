using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvcBoot.Models;
using WebMvcBoot.Repository;

namespace WebMvcBoot.Controllers
{
    public class ViagensController : Controller
    {
        RepositoryViagens repository = new RepositoryViagens();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Viagens model)
        {
            repository.Cadastrar(model);
            ModelState.Clear();
            return View();
        }
        public ActionResult Listar()
        {
           return View(repository.Listar());
        }
        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            return View(repository.Listar(id));
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            return View(repository.Listar(id));
        }
        [HttpPost]
        public ActionResult Editar(Viagens model)
        {
            repository.Editar(model);
            return RedirectToAction("Listar");
        }
        [HttpGet]
        public ActionResult Deletar(int id)
        {
            repository.Deletar(id);
            return RedirectToAction("Listar");
        }

    }
}