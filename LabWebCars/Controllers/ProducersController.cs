using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LabWebCars.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace LabWebCars.Controllers
{
    public class ProducersController : Controller
    {
        private readonly CarsContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProducersController(CarsContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Producers
        public async Task<IActionResult> Index()
        {
            var carsContext = _context.Producers.Include(p => p.Corporation);
            return View(await carsContext.ToListAsync());
        }
        public IActionResult ProducersMap()
        {
            return View();
        }

        // GET: Producers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers
                .Include(p => p.Corporation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // GET: Producers/Create
        public IActionResult Create()
        {
            ViewData["CorporationId"] = new SelectList(_context.Corporations, "Id", "Name");
            return View();
        }

        // POST: Producers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Country,CorporationId,Info,Icon")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                /*if (producer.ImageFile != null)
                {
                    string wwwrootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(producer.ImageFile.FileName);
                    string extension = Path.GetExtension(producer.ImageFile.FileName);
                    producer.Icon = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwrootPath + "/Icon/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await producer.ImageFile.CopyToAsync(fileStream);
                    }
                }*/

                _context.Add(producer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CorporationId"] = new SelectList(_context.Corporations, "Id", "Name", producer.CorporationId);
            return View(producer);
        }

        // GET: Producers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers.FindAsync(id);
            if (producer == null)
            {
                return NotFound();
            }
            ViewData["CorporationId"] = new SelectList(_context.Corporations, "Id", "Name", producer.CorporationId);
            return View(producer);
        }

        // POST: Producers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Country,CorporationId,Info,Icon")] Producer producer)
        {
            if (id != producer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*if (producer.ImageFile != null)
                    {
                        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "Icon", producer.Icon);
                        if (System.IO.File.Exists(imagePath))
                            System.IO.File.Delete(imagePath);

                        string wwwrootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(producer.ImageFile.FileName);
                        string extension = Path.GetExtension(producer.ImageFile.FileName);
                        producer.Icon = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwrootPath + "/Icon/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await producer.ImageFile.CopyToAsync(fileStream);
                        }
                    }*/

                    _context.Update(producer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducerExists(producer.Id))
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
            ViewData["CorporationId"] = new SelectList(_context.Corporations, "Id", "Name", producer.CorporationId);
            return View(producer);
        }

        // GET: Producers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producer = await _context.Producers
                .Include(p => p.Corporation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producer == null)
            {
                return NotFound();
            }

            return View(producer);
        }

        // POST: Producers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _context.Producers.FindAsync(id);

            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "Icon", producer.Icon);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            var car = from p in _context.Cars
                          where p.ProducerId == id
                          select p;
            foreach (var p in car)
            {
                var imagePathP = Path.Combine(_hostEnvironment.WebRootPath, "photo", p.Photo);
                if (System.IO.File.Exists(imagePathP))
                    System.IO.File.Delete(imagePathP);

                _context.Cars.Remove(p);
            }

            _context.Producers.Remove(producer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProducerExists(int id)
        {
            return _context.Producers.Any(e => e.Id == id);
        }
    }
}
