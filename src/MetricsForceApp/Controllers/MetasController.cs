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
    public class MetasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MetasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Metas
        [ClaimsAuthorize("MetaVendedor", "Read")]
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Metas.Include(v => v.Vendedor);
            return View(await applicationDbContext.ToListAsync());          
        }

        // GET: Metas/Details/5
        [ClaimsAuthorize("MetaVendedor", "Read")]
        public async Task<IActionResult>Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meta = await _context.Metas
                .Include(v => v.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meta == null)
            {
                return NotFound();
            }

            return View(meta);
        }

        // GET: Metas/Create
        [ClaimsAuthorize("MetaVendedor", "Create")]
        public IActionResult Create()
        {
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome");
            return View();
        }

        // POST: Metas/Create
        [ClaimsAuthorize("MetaVendedor", "Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Meta meta)
        {
            if (ModelState.IsValid)
            {
                _context.Metas.Add(meta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome", meta.VendedorId);
            return View(meta);
        }

        // GET: Metas/Edit/5
        [ClaimsAuthorize("MetaVendedor", "Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meta = await _context.Metas.FindAsync(id);
            if (meta == null)
            {
                return NotFound();
            }
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome", meta.VendedorId);
            return View(meta);
        }

        // POST: Metas/Edit/5
        [ClaimsAuthorize("MetaVendedor", "Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Meta meta)
        {
            if (id != meta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MetaExists(meta.Id))
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
            ViewData["VendedorId"] = new SelectList(_context.Vendedores, "Id", "Nome", meta.VendedorId);
            return View(meta);
        }

        // GET: Metas/Delete/5
        [ClaimsAuthorize("MetaVendedor", "Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meta = await _context.Metas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meta == null)
            {
                return NotFound();
            }

            return View(meta);
        }

        // POST: Metas/Delete/5
        [ClaimsAuthorize("MetaVendedor", "Delete")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meta = await _context.Metas.FindAsync(id);
            _context.Metas.Remove(meta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MetaExists(int id)
        {
            return _context.Metas.Any(e => e.Id == id);
        }
    }
}
