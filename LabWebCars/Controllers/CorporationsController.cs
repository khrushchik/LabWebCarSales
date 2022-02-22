using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LabWebCars.Models;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Hosting;

namespace LabWebCars.Controllers
{
    public class CorporationsController : Controller
    {
        private readonly CarsContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;


        public CorporationsController(CarsContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Corporations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Corporations.ToListAsync());
        }

        // GET: Corporations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corporation = await _context.Corporations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (corporation == null)
            {
                return NotFound();
            }

            return View(corporation);
        }

        // GET: Corporations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Corporations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Label,Info")] Corporation corporation)
        {
            if (ModelState.IsValid)
            {
                /*if (corporation.ImageFile != null)
                {
                    string wwwrootPath = _hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(corporation.ImageFile.FileName);
                    string extension = Path.GetExtension(corporation.ImageFile.FileName);
                    corporation.Label = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwrootPath + "/Image/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await corporation.ImageFile.CopyToAsync(fileStream);
                    }
                }*/

                _context.Add(corporation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(corporation);
        }

        // GET: Corporations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corporation = await _context.Corporations.FindAsync(id);
            if (corporation == null)
            {
                return NotFound();
            }
            return View(corporation);
        }

        // POST: Corporations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Label,Info")] Corporation corporation)
        {
            if (id != corporation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    /*if (corporation.ImageFile != null)
                    {
                        var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "Image", corporation.Label);
                        if (System.IO.File.Exists(imagePath))
                            System.IO.File.Delete(imagePath);

                        string wwwrootPath = _hostEnvironment.WebRootPath;
                        string fileName = Path.GetFileNameWithoutExtension(corporation.ImageFile.FileName);
                        string extension = Path.GetExtension(corporation.ImageFile.FileName);
                        corporation.Label = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwrootPath + "/Image/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await corporation.ImageFile.CopyToAsync(fileStream);
                        }
                    }*/

                    _context.Update(corporation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CorporationExists(corporation.Id))
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
            return View(corporation);
        }

        // GET: Corporations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var corporation = await _context.Corporations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (corporation == null)
            {
                return NotFound();
            }

            return View(corporation);
        }

        // POST: Corporations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var corporation = await _context.Corporations.FindAsync(id);

            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", corporation.Label);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            var producer = from t in _context.Producers
                        where t.CorporationId == id
                        select t;
            foreach (var t in producer)
            {
                var car = from p in _context.Cars
                              where p.ProducerId == t.Id
                              select p;
                foreach (var p in car)
                {
                    var imagePathP = Path.Combine(_hostEnvironment.WebRootPath, "photo", p.Photo);
                    if (System.IO.File.Exists(imagePathP))
                        System.IO.File.Delete(imagePathP);

                    _context.Cars.Remove(p);
                }
                var imagePathT = Path.Combine(_hostEnvironment.WebRootPath, "icon", t.Icon);
                if (System.IO.File.Exists(imagePathT))
                    System.IO.File.Delete(imagePathT);

                _context.Producers.Remove(t);
            }

            await _context.SaveChangesAsync();

            _context.Corporations.Remove(corporation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CorporationExists(int id)
        {
            return _context.Corporations.Any(e => e.Id == id);
        }
    }
}
