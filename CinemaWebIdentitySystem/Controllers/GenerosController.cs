using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemaWebIdentitySystem.Data;
using CinemaWebIdentitySystem.ViewModels;
using AutoMapper;
using CinemaWebIdentitySystem.Data.Entities;

namespace CinemaWebIdentitySystem.Controllers
{
    public class GenerosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GenerosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Generos
        public async Task<IActionResult> Index()
        {
            var generos = Mapper.Map<IEnumerable<Genero>, IEnumerable<GeneroViewModel>>(await _context.Generos.ToListAsync());
            return View(generos);
        }

        // GET: Generos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .SingleOrDefaultAsync(m => m.Id == id);
            var generoViewModel = Mapper.Map<Genero, GeneroViewModel>(genero);
            if (generoViewModel == null)
            {
                return NotFound();
            }

            return View(generoViewModel);
        }

        // GET: Generos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Generos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao")] GeneroViewModel generoViewModel)
        {
            if (ModelState.IsValid)
            {
                var genero = Mapper.Map<GeneroViewModel, Genero>(generoViewModel);
                _context.Add(genero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generoViewModel);
        }

        // GET: Generos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos.SingleOrDefaultAsync(m => m.Id == id);
            var generoViewModel = Mapper.Map<Genero, GeneroViewModel>(genero);
            if (generoViewModel == null)
            {
                return NotFound();
            }
            return View(generoViewModel);
        }

        // POST: Generos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao")] GeneroViewModel generoViewModel)
        {
            if (id != generoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var genero = Mapper.Map<GeneroViewModel, Genero>(generoViewModel);
                    _context.Update(genero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneroViewModelExists(generoViewModel.Id))
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
            return View(generoViewModel);
        }

        // GET: Generos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .SingleOrDefaultAsync(m => m.Id == id);
            var generoViewModel = Mapper.Map<Genero, GeneroViewModel>(genero);
            if (generoViewModel == null)
            {
                return NotFound();
            }

            return View(generoViewModel);
        }

        // POST: Generos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var genero = await _context.Generos.SingleOrDefaultAsync(m => m.Id == id);
            _context.Generos.Remove(genero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneroViewModelExists(int id)
        {
            return _context.Generos.Any(e => e.Id == id);
        }
    }
}
