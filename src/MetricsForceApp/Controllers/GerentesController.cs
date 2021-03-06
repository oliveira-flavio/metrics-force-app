using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MetricsForceApp.Data;
using MetricsForceApp.Models;
using MetricsForceApp.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace MetricsForceApp.Controllers
{
    [Authorize]
    public class GerentesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GerentesController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: Gerentes
        [ClaimsAuthorize("Gerente", "Read")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gerentes.ToListAsync());
        }

        // GET: Gerentes/Details/5
        [ClaimsAuthorize("Gerente", "Read")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gerente = await _context.Gerentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gerente == null)
            {
                return NotFound();
            }

            return View(gerente);
        }
        //Verificar com o Bruno
        //public ActionResult VendasTotais(int? id)
        //{
        //    ViewBag.ValorTotal = _context.RegistroVendas.Select(r => r.ValorVenda).Sum();

        //    return View();
        //}

        // GET: Gerentes/Create
        [ClaimsAuthorize("Gerente", "Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gerentes/Create
        [ClaimsAuthorize("Gerente", "Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Gerente gerente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gerente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gerente);
        }

        // GET: Gerentes/Edit/5
        [ClaimsAuthorize("Gerente", "Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gerente = await _context.Gerentes.FindAsync(id);
            if (gerente == null)
            {
                return NotFound();
            }
            return View(gerente);
        }

        // POST: Gerentes/Edit/5
        [ClaimsAuthorize("Gerente", "Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Gerente gerente)
        {
            if (id != gerente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gerente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GerenteExists(gerente.Id))
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
            return View(gerente);
        }

        // GET: Gerentes/Delete/5
        [ClaimsAuthorize("Gerente", "Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gerente = await _context.Gerentes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gerente == null)
            {
                return NotFound();
            }

            return View(gerente);
        }

        // POST: Gerentes/Delete/5
        [ClaimsAuthorize("Gerente", "Delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gerente = await _context.Gerentes.FindAsync(id);
            _context.Gerentes.Remove(gerente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GerenteExists(int id)
        {
            return _context.Gerentes.Any(e => e.Id == id);
        }
    }
}
