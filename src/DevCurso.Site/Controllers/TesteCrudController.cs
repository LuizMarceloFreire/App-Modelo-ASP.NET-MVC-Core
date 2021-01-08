using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCurso.Site.Data;
using DevCurso.Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCurso.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _context;
        public TesteCrudController(MeuDbContext contexto)
        {
            _context = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Luiz Marcelo",
                DataNascimento = DateTime.Now,
                Email = "luiz@luiz.com"
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            BuscarAluno(aluno);

            UpdateAluno(aluno);

            RemoverAluno(aluno);

            return View();
        }

        private void RemoverAluno(Aluno aluno)
        {
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }

        private void UpdateAluno(Aluno aluno)
        {
            aluno.Nome = "João";
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }

        private void BuscarAluno(Aluno aluno)
        {
            var aluno2 = _context.Alunos.Find(aluno.Id);
            var aluno3 = _context.Alunos.FirstOrDefault(x => x.Email.Equals("luiz@luiz.com"));
            var aluno4 = _context.Alunos.Where(x => x.Nome == "Luiz Marcelo").ToList(); 
        }
    }
}