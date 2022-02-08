using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TantsuvõistlusMVC.Data;
using TantsuvõistlusMVC.Models;

namespace TantsuvõistlusMVC.Controllers
{
    public class VõistlusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VõistlusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Võistlus/Registreeri
        public IActionResult Registreeri()
        {
            return View();
        }

        // POST: Võistlus/Registreeri
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registreeri([Bind("Id, Tantsupaari_Nimi")] Võistlus võistlus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(võistlus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(võistlus);
        }

        // GET: Võistlus/Voor1
        public async Task<IActionResult> Voor1()
        {
            var model = _context.Võistlus.Where(e => e.Voor1 == 0);
            return View(await model.ToListAsync());
        }
        // GET: Võistlus/Voor2
        public async Task<IActionResult> Voor2()
        {
            var model = _context.Võistlus.Where(e => e.Voor1 > 0 && e.Voor2 == 0);
            return View(await model.ToListAsync());
        }
        // GET: Võistlus/Voor3
        public async Task<IActionResult> Voor3()
        {
            var model = _context.Võistlus.Where(e => e.Voor1 > 0 && e.Voor2 > 0 && e.Voor3 == 0);
            return View(await model.ToListAsync());
        }

        // GET: Võistlus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Võistlus.ToListAsync());
        }

        // GET: Võistlus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var võistlus = await _context.Võistlus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (võistlus == null)
            {
                return NotFound();
            }

            return View(võistlus);
        }

        // GET: Võistlus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Võistlus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tantsupaari_Nimi,Voor1,Voor2,Voor3,KeskmineHinne")] Võistlus võistlus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(võistlus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(võistlus);
        }

        // GET: Võistlus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var võistlus = await _context.Võistlus.FindAsync(id);
            if (võistlus == null)
            {
                return NotFound();
            }
            return View(võistlus);
        }

        // POST: Võistlus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tantsupaari_Nimi,Voor1,Voor2,Voor3,KeskmineHinne")] Võistlus võistlus)
        {
            if (id != võistlus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(võistlus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VõistlusExists(võistlus.Id))
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
            return View(võistlus);
        }

        //GET: Võistlus/HindaPaari
        public async Task<IActionResult> HindaPaari(int id, string voor, int tulemus)
        {
            var paar = await _context.Võistlus.FindAsync(id);
            if(paar == null)
            {
                return NotFound();
            }

            switch (voor)
            {
                case nameof(paar.Voor1):
                    {
                        paar.Voor1 = tulemus;
                        break;
                    }
                case nameof(paar.Voor2):
                    {
                        paar.Voor2 = tulemus;
                        break;
                    }
                case nameof(paar.Voor3):
                    {
                        paar.Voor3 = tulemus;
                        break;
                    }
                default:
                    {
                        return NotFound();
                        break;
                    }
            }

            try
            {
                _context.Update(paar);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VõistlusExists(paar.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(voor);
        }

        // GET: Eksams/Luba
        public async Task<IActionResult> Koondhinne()
        {
            var model = _context.Võistlus.Select(e => new KeskmineHinneViewModel()
            {
                Id = e.Id,
                Tantsupaari_Nimi = e.Tantsupaari_Nimi,
                Voor1 = e.Voor1 == 0 ? "Hindamata" : $"{e.Voor1}",
                Voor2 = e.Voor2 == 0 ? "Hindamata" : $"{e.Voor2}",
                Voor3 = e.Voor3 == 0 ? "Hindamata" : $"{e.Voor3}",
                KeskmineHinne = (e.Voor1+e.Voor2+e.Voor3)/3
            });
            return View(await model.ToListAsync());
        }


        // GET: Võistlus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var võistlus = await _context.Võistlus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (võistlus == null)
            {
                return NotFound();
            }

            return View(võistlus);
        }

        // POST: Võistlus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var võistlus = await _context.Võistlus.FindAsync(id);
            _context.Võistlus.Remove(võistlus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VõistlusExists(int id)
        {
            return _context.Võistlus.Any(e => e.Id == id);
        }
    }
}
