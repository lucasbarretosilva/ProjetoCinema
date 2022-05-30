using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;

namespace ProjetoCinema.Controllers
{
    public class SessaoController : Controller
    {
        private readonly ProjetoCinemaContext _context;

        public SessaoController(ProjetoCinemaContext context)
        {
            _context = context;
        }

        // GET: Sessao
        public async Task<IActionResult> Index()
        {
            var projetoCinemaContext = _context.Sessao.Include(s => s.Filme).Include(s => s.Sala);
            return View(await projetoCinemaContext.ToListAsync());
        }

        // GET: Sessao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessao
                .Include(s => s.Filme)
                .Include(s => s.Sala)
                .FirstOrDefaultAsync(m => m.SessaoId == id);
            if (sessao == null)
            {
                return NotFound();
            }

            return View(sessao);
        }

        // GET: Sessao/Create
        public IActionResult Create()
        {
            ViewData["FilmeId"] = new SelectList(_context.Filme, "FilmeId", "FilmeNome");
            ViewData["SalaId"] = new SelectList(_context.Sala, "SalaId", "SalaId");
            return View();
        }

        // POST: Sessao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SessaoId,NumeroSessao,FilmeId,SalaId,Horario,HorarioFinal")] Sessao sessao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sessao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmeId"] = new SelectList(_context.Filme, "FilmeId", "FilmeNome",sessao.FilmeId);
            ViewData["SalaId"] = new SelectList(_context.Sala, "SalaId", "SalaId", sessao.SalaId);
            return View(sessao);
        }

        // GET: Sessao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessao.FindAsync(id);
            if (sessao == null)
            {
                return NotFound();
            }
            ViewData["FilmeId"] = new SelectList(_context.Filme, "FilmeId", "Descricao", sessao.FilmeId);
            ViewData["SalaId"] = new SelectList(_context.Sala, "SalaId", "SalaId", sessao.SalaId);
            return View(sessao);
        }

        // POST: Sessao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SessaoId,NumeroSessao,FilmeId,SalaId,Horario,HorarioFinal")] Sessao sessao)
        {
            if (id != sessao.SessaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sessao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SessaoExists(sessao.SessaoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FilmeId"] = new SelectList(_context.Filme, "FilmeId", "Descricao", sessao.FilmeId);
            ViewData["SalaId"] = new SelectList(_context.Sala, "SalaId", "SalaId", sessao.SalaId);
            return View(sessao);
        }

        // GET: Sessao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sessao = await _context.Sessao
                .Include(s => s.Filme)
                .Include(s => s.Sala)
                .FirstOrDefaultAsync(m => m.SessaoId == id);
            if (sessao == null)
            {
                return NotFound();
            }

            return View(sessao);
        }

        // POST: Sessao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sessao = await _context.Sessao.FindAsync(id);
            _context.Sessao.Remove(sessao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SessaoExists(int id)
        {
            return _context.Sessao.Any(e => e.SessaoId == id);
        }
    }
}
