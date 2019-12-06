using System.Collections.Generic;

using AgendTelefonica.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendTelefonica.Controllers
{
   public class ContatoController : Controller
    {
            Contato contato;
     
        public ContatoController()
        {
            contato = new Contato();
        }
        // GET: Contato
        public ActionResult Index()
        {
            return View(contato.RetornarTodos());
            //  "Aléxia".ToUpper();
        }

        // GET: Contato/Details/5
        public ActionResult Details(int id)
        {
            return View(contato.BuscarContato(id)
       ?? new Contato());
         
        }

        // GET: Contato/Create
        public ActionResult Create()
        {
          
            return View();
        }

        // POST: Contato/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contato contato)
        {
            try
            {
                // TODO: Add insert logic here

                contato.IncluirContato(contato);
                return View("Index", contato.RetornarTodos());
            }
            catch
            {
                return View();
            }
        }

        // GET: Contato/Edit/5
        public ActionResult Edit(int id)
        {
            return View(contato.BuscarContato(id)
                   ?? new Contato());
        }

        // POST: Contato/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contato contato)
        {
            try
            {
                contato.EditarContato(contato);
                return View("Index", contato.RetornarTodos());
                    }
            catch
            {
                return View();
            }
        }

        // GET: Contato/Delete/5
        public ActionResult Delete(int id)
        {
            return View("Index", contato.RetornarTodos());
        }

       
        }
    }
