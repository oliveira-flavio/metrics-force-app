using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MetricsForceApp.Data;
using MetricsForceApp.Models;

namespace MetricsForceApp.Controllers
{
    public class ComissoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComissoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comissoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comissoes.ToListAsync());
        }

        // GET: Comissoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissao = await _context.Comissoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comissao == null)
            {
                return NotFound();
            }

            return View(comissao);
        }

        // GET: Comissoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comissoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Valor,MesReferencia,Id")] Comissao comissao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comissao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comissao);
        }

        // GET: Comissoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissao = await _context.Comissoes.FindAsync(id);
            if (comissao == null)
            {
                return NotFound();
            }
            return View(comissao);
        }

        // POST: Comissoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Valor,MesReferencia,Id")] Comissao comissao)
        {
            if (id != comissao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comissao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComissaoExists(comissao.Id))
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
            return View(comissao);
        }

        // GET: Comissoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comissao = await _context.Comissoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comissao == null)
            {
                return NotFound();
            }

            return View(comissao);
        }

        // POST: Comissoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comissao = await _context.Comissoes.FindAsync(id);
            _context.Comissoes.Remove(comissao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComissaoExists(int id)
        {
            return _context.Comissoes.Any(e => e.Id == id);
        }
    }
}
