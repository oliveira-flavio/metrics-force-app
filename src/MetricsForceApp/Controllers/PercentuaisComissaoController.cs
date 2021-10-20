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
    public class PercentuaisComissaoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PercentuaisComissaoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PercentuaisComissao
        public async Task<IActionResult> Index()
        {
            return View(await _context.PercentuaisComissao.ToListAsync());
        }

        // GET: PercentuaisComissao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var percentualComissao = await _context.PercentuaisComissao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (percentualComissao == null)
            {
                return NotFound();
            }

            return View(percentualComissao);
        }

        // GET: PercentuaisComissao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PercentuaisComissao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PorcentagemComissaoBase,PorcentagemComissaoBronze,PorcentagemComissaoPrata,PorcentagemComissaoOuro,PorcentagemComissaoDiamante,Id")] PercentualComissao percentualComissao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(percentualComissao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(percentualComissao);
        }

        // GET: PercentuaisComissao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var percentualComissao = await _context.PercentuaisComissao.FindAsync(id);
            if (percentualComissao == null)
            {
                return NotFound();
            }
            return View(percentualComissao);
        }

        // POST: PercentuaisComissao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PorcentagemComissaoBase,PorcentagemComissaoBronze,PorcentagemComissaoPrata,PorcentagemComissaoOuro,PorcentagemComissaoDiamante,Id")] PercentualComissao percentualComissao)
        {
            if (id != percentualComissao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(percentualComissao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PercentualComissaoExists(percentualComissao.Id))
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
            return View(percentualComissao);
        }

        // GET: PercentuaisComissao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var percentualComissao = await _context.PercentuaisComissao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (percentualComissao == null)
            {
                return NotFound();
            }

            return View(percentualComissao);
        }

        // POST: PercentuaisComissao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var percentualComissao = await _context.PercentuaisComissao.FindAsync(id);
            _context.PercentuaisComissao.Remove(percentualComissao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PercentualComissaoExists(int id)
        {
            return _context.PercentuaisComissao.Any(e => e.Id == id);
        }
    }
}
