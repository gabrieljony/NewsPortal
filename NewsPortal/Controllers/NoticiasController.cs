﻿using NewsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsPortal.Controllers
{
    public class NoticiasController : Controller
    {
        // GET: Noticias
        public ActionResult Index()
        {
            return View(RepositorioNoticias.Noticias);
        }

        public ActionResult Detalhes(int id)
        {
            var noticias = RepositorioNoticias.Noticias.FirstOrDefault(n => n.Id == id);
            return View(noticias);
        }

        public ActionResult Buscar(string texto)
        {
            var noticias = RepositorioNoticias.Noticias.Where(n => n.Titulo.Contains(texto) || n.Conteudo.Contains(texto));
            return View(noticias);
        }
    }
}