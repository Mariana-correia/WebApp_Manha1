using Microsoft.AspNetCore.Mvc;
using WebApp_Manha1.Entidades;

namespace WebApp_Manha1.Controllers
{
    public class PermissaoController : Controller
    {
        private Contexto contexto;

        public PermissaoController(Contexto db)
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View(contexto.PERMISSAO.ToList());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SalvarDados(PermissaoEntidade dados)
        {
            contexto.PERMISSAO.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
