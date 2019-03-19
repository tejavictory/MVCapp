using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace Application.Controllers
{
    public class CreditsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CreditsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Credits
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.NumberSortParm = sortOrder == "Number" ? "number_desc" : "Number";
            ViewBag.AbbrSortParm = sortOrder == "Abbr" ? "abbr_desc" : "Abbr";
            ViewBag.IsSort = sortOrder == "Is" ? "is_desc" : "Is";
            
            var students = from s in _context.Credits
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.CreditId.Equals(Int32.Parse(searchString))
                                       || s.CreditName.Contains(searchString)|| s.CreditAbbr.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Abbr":
                    students = students.OrderBy(s => s.CreditAbbr);
                    break;
                case "abbr_desc":
                    students = students.OrderByDescending(s => s.CreditAbbr);
                    break;
                case "Number":
                    students = students.OrderBy(s => s.CreditId);
                    break;
                case "number_desc":
                    students = students.OrderByDescending(s => s.CreditId);
                    break;
                case "name_desc":
                    students = students.OrderByDescending(s => s.CreditName);
                    break;
                case "Is":
                    students = students.OrderBy(s => s.IsSpring);
                    break;
                case "is_desc":
                    students = students.OrderByDescending(s => s.IsSpring);
                    break;
                default:
                    students = students.OrderBy(s => s.CreditId);
                    break;
            }
            return View(students.ToList());



 //           return View(await _context.Credits.ToListAsync());
        }

        // GET: Credits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = await _context.Credits
                .FirstOrDefaultAsync(m => m.CreditId == id);
            if (credit == null)
            {
                return NotFound();
            }

            return View(credit);
        }

        // GET: Credits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Credits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreditId,CreditAbbr,CreditName,IsSummer,IsSpring,IsFall")] Credit credit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(credit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(credit);
        }

        // GET: Credits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = await _context.Credits.FindAsync(id);
            if (credit == null)
            {
                return NotFound();
            }
            return View(credit);
        }

        // POST: Credits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CreditId,CreditAbbr,CreditName,IsSummer,IsSpring,IsFall")] Credit credit)
        {
            if (id != credit.CreditId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(credit);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreditExists(credit.CreditId))
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
            return View(credit);
        }

        // GET: Credits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var credit = await _context.Credits
                .FirstOrDefaultAsync(m => m.CreditId == id);
            if (credit == null)
            {
                return NotFound();
            }

            return View(credit);
        }

        // POST: Credits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var credit = await _context.Credits.FindAsync(id);
            _context.Credits.Remove(credit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreditExists(int id)
        {
            return _context.Credits.Any(e => e.CreditId == id);
        }
    }
}
