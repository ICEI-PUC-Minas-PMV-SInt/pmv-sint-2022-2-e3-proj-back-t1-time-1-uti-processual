using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using utip_backend.Data;
using utip_backend.Models;

namespace utip_backend.Controllers
{
    public class ProcessesController : Controller
    {
        private readonly ProcessDbContext _context;

        public ProcessesController(ProcessDbContext context)
        {
            _context = context;
        }

        // GET: Processes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Processo.ToListAsync());
        }

        // GET: Processes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Processo == null)
            {
                return NotFound();
            }

            var processModel = await _context.Processo
                .FirstOrDefaultAsync(m => m.ProcessID == id);
            if (processModel == null)
            {
                return NotFound();
            }

            return View(processModel);
        }

        // GET: Processes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Processes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProcessID,NumLegalProcess,Defendant,NaturalidadeReu,FiliacaoReu,DataNascReu,TelefoneReu,DefensoriaPublica,Attorney,TipoPenal,DefAddress,NumeroREDS,DataDoCrime,LocalDoCrime,NumInqueritoPolicial,IdStatus,TxStatus,ProcessTimeCounter")] ProcessModel processModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(processModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(processModel);
        }

        // GET: Processes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Processo == null)
            {
                return NotFound();
            }

            var processModel = await _context.Processo.FindAsync(id);
            if (processModel == null)
            {
                return NotFound();
            }
            return View(processModel);
        }

        // POST: Processes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProcessID,NumLegalProcess,Defendant,NaturalidadeReu,FiliacaoReu,DataNascReu,TelefoneReu,DefensoriaPublica,Attorney,TipoPenal,DefAddress,NumeroREDS,DataDoCrime,LocalDoCrime,NumInqueritoPolicial,IdStatus,TxStatus,ProcessTimeCounter")] ProcessModel processModel)
        {
            if (id != processModel.ProcessID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(processModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessModelExists(processModel.ProcessID))
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
            return View(processModel);
        }

        // GET: Processes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Processo == null)
            {
                return NotFound();
            }

            var processModel = await _context.Processo
                .FirstOrDefaultAsync(m => m.ProcessID == id);
            if (processModel == null)
            {
                return NotFound();
            }

            return View(processModel);
        }

        // POST: Processes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Processo == null)
            {
                return Problem("Entity set 'ProcessDbContext.Processo'  is null.");
            }
            var processModel = await _context.Processo.FindAsync(id);
            if (processModel != null)
            {
                _context.Processo.Remove(processModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessModelExists(int id)
        {
          return _context.Processo.Any(e => e.ProcessID == id);
        }
    }
}
