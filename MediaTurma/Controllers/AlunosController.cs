using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaTurma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaTurma.Controllers
{
    public class AlunosController : Controller

    {
        Alunos alunos;
        public AlunosController()
        {
            alunos = new Alunos();
        }
    
       // GET: Alunos
        public ActionResult Index()
        {
            return View(alunos.RetornarAlunos() ?? new List<Alunos>());
        }

        // GET: Alunos/Details/5
        public ActionResult Details(string nomeAluno)
        {
            
            return View(alunos.BuscarAluno(nomeAluno) ?? new Alunos());
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alunos aluno)
        {
            try
            {
                // TODO: Add insert logic here
                alunos.IncluirAluno(aluno);
                return View("index", alunos.RetornarAlunos());
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(string nomeAluno)
        {
            return View(alunos.BuscarAluno(nomeAluno) ?? new Alunos());
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Alunos alunos)
        {
            try
            {
                // TODO: Add update logic here
                alunos.EditarNota(alunos);
                return View("index", alunos.RetornarAlunos());
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(string nomeAluno)
        {
            alunos.ExcluirNota(nomeAluno);
            return View("index", alunos.RetornarAlunos());
        }

      
        
    }
}