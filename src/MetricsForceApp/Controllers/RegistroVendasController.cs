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
    public class RegistroVendasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroVendasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RegistroVendas
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroVendas.ToListAsync());
        }

        // GET: RegistroVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroVenda = await _context.RegistroVendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroVenda == null)
            {
                return NotFound();
            }

            return View(registroVenda);
        }

        // GET: RegistroVendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuantidadeItem,ValorVenda,QuantidadeTicket,Data,Id")] RegistroVenda registroVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroVenda);
        }

        // GET: RegistroVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroVenda = await _context.RegistroVendas.FindAsync(id);
            if (registroVenda == null)
            {
                return NotFound();
            }
            return View(registroVenda);
        }

        // POST: RegistroVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuantidadeItem,ValorVenda,QuantidadeTicket,Data,Id")] RegistroVenda registroVenda)
        {
            if (id != registroVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroVendaExists(registroVenda.Id))
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
            return View(registroVenda);
        }

        // GET: RegistroVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroVenda = await _context.RegistroVendas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroVenda == null)
            {
                return NotFound();
            }

            return View(registroVenda);
        }

        // POST: RegistroVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registroVenda = await _context.RegistroVendas.FindAsync(id);
            _context.RegistroVendas.Remove(registroVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroVendaExists(int id)
        {
            return _context.RegistroVendas.Any(e => e.Id == id);
        }
    }
}
