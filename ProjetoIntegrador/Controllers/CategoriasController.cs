using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria() {
            CategoriaId = 1,
            Quadras = "Q1"
            },
            new Categoria() {
            CategoriaId = 2,
            Quadras = "Q2"
            },
            new Categoria() {
            CategoriaId = 3,
            Quadras = "Q3"
            },
            new Categoria() {
            CategoriaId = 4,
            Quadras = "Ginásio"
            },
        };
        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }
    }
}