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
    public class DegreePlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreePlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreePlans
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var applicationDbContext = _context.DegreePlans.Include(d => d.Student);
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.NumberSortParm = sortOrder == "Number" ? "number_desc" : "Number";
            ViewBag.AbbrSortParm = sortOrder == "Abbr" ? "abbr_desc" : "Abbr";
            ViewBag.TermSort = sortOrder == "Term" ? "term_desc" : "Term";

            var students = from s in _context.DegreePlans
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                //typecast for id searchstring.
                students = students.Where(s => s.DegreePlanId.Equals(searchString)
                                       || s.DegreePlanAbbr.Contains(searchString) || s.DegreePlanName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Abbr":
                    students = students.OrderBy(s => s.DegreePlanAbbr);
                    break;
                case "abbr_desc":
                    students = students.OrderByDescending(s => s.DegreePlanAbbr);
                    break;
                case "Number":
                    students = students.OrderBy(s => s.StudentId);
                    break;
                case "number_desc":
                    students = students.OrderByDescending(s => s.StudentId);
                    break;
                case "term_desc":
                    students = students.OrderByDescending(s => s.DegreePlanSelected);
                    break;
                case "Term":
                    students = students.OrderBy(s => s.DegreePlanSelected);
                    break;
                case "name_desc":
                    students = students.OrderByDescending(s => s.DegreePlanName);
                    break;
                default:
                    students = students.OrderBy(s => s.DegreePlanId);
                    break;
            }
            //return View(students.ToList());
            return View(await students.ToListAsync());

            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: DegreePlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans
                .Include(d => d.Student)
                .FirstOrDefaultAsync(m => m.DegreePlanId == id);
            if (degreePlan == null)
            {
                return NotFound();
            }

            return View(degreePlan);
        }

        // GET: DegreePlans/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId");
            return View();
        }

        // POST: DegreePlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DegreePlanId,StudentId,DegreePlanAbbr,DegreePlanName,DegreePlanSelected")] DegreePlan degreePlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreePlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreePlan.StudentId);
            return View(degreePlan);
        }

        // GET: DegreePlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans.FindAsync(id);
            if (degreePlan == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreePlan.StudentId);
            return View(degreePlan);
        }

        // POST: DegreePlans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DegreePlanId,StudentId,DegreePlanAbbr,DegreePlanName,DegreePlanSelected")] DegreePlan degreePlan)
        {
            if (id != degreePlan.DegreePlanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreePlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreePlanExists(degreePlan.DegreePlanId))
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
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", degreePlan.StudentId);
            return View(degreePlan);
        }

        // GET: DegreePlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreePlan = await _context.DegreePlans
                .Include(d => d.Student)
                .FirstOrDefaultAsync(m => m.DegreePlanId == id);
            if (degreePlan == null)
            {
                return NotFound();
            }

            return View(degreePlan);
        }

        // POST: DegreePlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreePlan = await _context.DegreePlans.FindAsync(id);
            _context.DegreePlans.Remove(degreePlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreePlanExists(int id)
        {
            return _context.DegreePlans.Any(e => e.DegreePlanId == id);
        }
    }
}
