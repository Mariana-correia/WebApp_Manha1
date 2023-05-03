using Microsoft.AspNetCore.Mvc;
using WebApp_Manha1.Entidades;

namespace WebApp_Manha1.Controllers
{
    public class CategoriaController : Controller
    {
        private Contexto db;

        public CategoriaController(Contexto _db)
        {
            this.db = _db;
        }
        public ActionResult Lista() 
        {
            return View(db.Categoria.ToList());
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(Categoria dados)
        {
            db.Categoria.Add(dados);
            db.SaveChanges();
            return RedirectToAction("lista");
        }
    }
}
