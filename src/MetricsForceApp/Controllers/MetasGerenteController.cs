using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MetricsForceApp.Data;
using MetricsForceApp.Models;
using Microsoft.AspNetCore.Authorization;
using MetricsForceApp.Extensions;

namespace MetricsForceApp.Controllers
{
    [Authorize]
    public class MetasGerenteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MetasGerenteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MetasGerente
        [ClaimsAuthorize("MetaGerente", "Read")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MetasGerentes.Include(m => m.Gerente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MetasGerente/Details/5
        [ClaimsAuthorize("MetaGerente", "Read")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metaGerente = await _context.MetasGerentes
                .Include(m => m.Gerente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metaGerente == null)
            {
                return NotFound();
            }

            return View(metaGerente);
        }

        // GET: MetasGerente/Create
        [ClaimsAuthorize("MetaGerente", "Create")]
        public IActionResult Create()
        {
            ViewData["GerenteId"] = new SelectList(_context.Gerentes, "Id", "Nome");
            return View();
        }

        // POST: MetasGerente/Create
        [ClaimsAuthorize("MetaGerente", "Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( MetaGerente metaGerente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(metaGerente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GerenteId"] = new SelectList(_context.Gerentes, "Id", "CodigoFuncionario", metaGerente.GerenteId);
            return View(metaGerente);
        }

        // GET: MetasGerente/Edit/5
        [ClaimsAuthorize("MetaGerente", "Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metaGerente = await _context.MetasGerentes.FindAsync(id);
            if (metaGerente == null)
            {
                return NotFound();
            }
            ViewData["GerenteId"] = new SelectList(_context.Gerentes, "Id", "Nome", metaGerente.GerenteId);
            return View(metaGerente);
        }

        // POST: MetasGerente/Edit/5
        [ClaimsAuthorize("MetaGerente", "Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MetaGerente metaGerente)
        {
            if (id != metaGerente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metaGerente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetaGerenteExists(metaGerente.Id))
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
            ViewData["GerenteId"] = new SelectList(_context.Gerentes, "Id", "CodigoFuncionario", metaGerente.GerenteId);
            return View(metaGerente);
        }

        // GET: MetasGerente/Delete/5
        [ClaimsAuthorize("MetaGerente", "Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var metaGerente = await _context.MetasGerentes
                .Include(m => m.Gerente)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metaGerente == null)
            {
                return NotFound();
            }

            return View(metaGerente);
        }

        // POST: MetasGerente/Delete/5
        [ClaimsAuthorize("MetaGerente", "Delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var metaGerente = await _context.MetasGerentes.FindAsync(id);
            _context.MetasGerentes.Remove(metaGerente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetaGerenteExists(int id)
        {
            return _context.MetasGerentes.Any(e => e.Id == id);
        }
    }
}
