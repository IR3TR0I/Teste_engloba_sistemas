﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EnglobaSistemasTeste.Contexts;
using EnglobaSistemasTeste.Models;

namespace EnglobaSistemasTeste.Controllers
{
    public class EnderecoesController : Controller
    {
        private readonly EnglobaContext _context;

        public EnderecoesController(EnglobaContext context)
        {
            _context = context;
        }

        // GET: Enderecoes
        public async Task<IActionResult> Index()
        {
              return _context.Enderecos != null ? 
                          View(await _context.Enderecos.ToListAsync()) :
                          Problem("Entity set 'EnglobaContext.Enderecos'  is null.");
        }

        // GET: Enderecoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Enderecos == null)
            {
                return NotFound();
            }

            var endereco = await _context.Enderecos
                .FirstOrDefaultAsync(m => m.IdEndereco == id);
            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);
        }

        // GET: Enderecoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enderecoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEndereco,Endereco1,Numero,Complemento,Bairro,Cidade,Referencia")] Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                _context.Add(endereco);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(endereco);
        }

        // GET: Enderecoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Enderecos == null)
            {
                return NotFound();
            }

            var endereco = await _context.Enderecos.FindAsync(id);
            if (endereco == null)
            {
                return NotFound();
            }
            return View(endereco);
        }

        // POST: Enderecoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEndereco,Endereco1,Numero,Complemento,Bairro,Cidade,Referencia")] Endereco endereco)
        {
            if (id != endereco.IdEndereco)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(endereco);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnderecoExists(endereco.IdEndereco))
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
            return View(endereco);
        }

        // GET: Enderecoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Enderecos == null)
            {
                return NotFound();
            }

            var endereco = await _context.Enderecos
                .FirstOrDefaultAsync(m => m.IdEndereco == id);
            if (endereco == null)
            {
                return NotFound();
            }

            return View(endereco);
        }

        // POST: Enderecoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Enderecos == null)
            {
                return Problem("Entity set 'EnglobaContext.Enderecos'  is null.");
            }
            var endereco = await _context.Enderecos.FindAsync(id);
            if (endereco != null)
            {
                _context.Enderecos.Remove(endereco);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnderecoExists(int id)
        {
          return (_context.Enderecos?.Any(e => e.IdEndereco == id)).GetValueOrDefault();
        }
    }
}
