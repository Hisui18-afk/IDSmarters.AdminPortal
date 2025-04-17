using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IDSmarters.AdminPortal.Data.Migrations;
using IDSmarters.AdminPortal.Models;

namespace IDSmarters.AdminPortal.Controllers
{
    public class AdminDashboardsController : Controller
    {
        private readonly IDSmarterDbContext _context;

        public AdminDashboardsController(IDSmarterDbContext context)
        {
            _context = context;
        }

        // GET: AdminDashboards
        public async Task<IActionResult> Index()
        {
            var iDSmarterDbContext = _context.AdminDashboard.Include(a => a.DeanDashboards).Include(a => a.InstructorDashboards).Include(a => a.StudentDashboards);
            return View(await iDSmarterDbContext.ToListAsync());
        }

        // GET: AdminDashboards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminDashboard = await _context.AdminDashboard
                .Include(a => a.DeanDashboards)
                .Include(a => a.InstructorDashboards)
                .Include(a => a.StudentDashboards)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminDashboard == null)
            {
                return NotFound();
            }

            return View(adminDashboard);
        }

        // GET: AdminDashboards/Create
        public IActionResult Create()
        {
            ViewData["DeanDashboardId"] = new SelectList(_context.DeanDashboard, "Id", "Id");
            ViewData["InstructorDashboardId"] = new SelectList(_context.InstructorDashboard, "Id", "Id");
            ViewData["StudentDashboardId"] = new SelectList(_context.StudentDashboard, "Id", "Id");
            return View();
        }

        // POST: AdminDashboards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,PhoneNumber,Address,TotalStudents,TotalInstructors,TotalDeans,StudentDashboardId,DeanDashboardId,InstructorDashboardId")] AdminDashboard adminDashboard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminDashboard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeanDashboardId"] = new SelectList(_context.DeanDashboard, "Id", "Id", adminDashboard.DeanDashboardId);
            ViewData["InstructorDashboardId"] = new SelectList(_context.InstructorDashboard, "Id", "Id", adminDashboard.InstructorDashboardId);
            ViewData["StudentDashboardId"] = new SelectList(_context.StudentDashboard, "Id", "Id", adminDashboard.StudentDashboardId);
            return View(adminDashboard);
        }

        // GET: AdminDashboards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminDashboard = await _context.AdminDashboard.FindAsync(id);
            if (adminDashboard == null)
            {
                return NotFound();
            }
            ViewData["DeanDashboardId"] = new SelectList(_context.DeanDashboard, "Id", "Id", adminDashboard.DeanDashboardId);
            ViewData["InstructorDashboardId"] = new SelectList(_context.InstructorDashboard, "Id", "Id", adminDashboard.InstructorDashboardId);
            ViewData["StudentDashboardId"] = new SelectList(_context.StudentDashboard, "Id", "Id", adminDashboard.StudentDashboardId);
            return View(adminDashboard);
        }

        // POST: AdminDashboards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,PhoneNumber,Address,TotalStudents,TotalInstructors,TotalDeans,StudentDashboardId,DeanDashboardId,InstructorDashboardId")] AdminDashboard adminDashboard)
        {
            if (id != adminDashboard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminDashboard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminDashboardExists(adminDashboard.Id))
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
            ViewData["DeanDashboardId"] = new SelectList(_context.DeanDashboard, "Id", "Id", adminDashboard.DeanDashboardId);
            ViewData["InstructorDashboardId"] = new SelectList(_context.InstructorDashboard, "Id", "Id", adminDashboard.InstructorDashboardId);
            ViewData["StudentDashboardId"] = new SelectList(_context.StudentDashboard, "Id", "Id", adminDashboard.StudentDashboardId);
            return View(adminDashboard);
        }

        // GET: AdminDashboards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminDashboard = await _context.AdminDashboard
                .Include(a => a.DeanDashboards)
                .Include(a => a.InstructorDashboards)
                .Include(a => a.StudentDashboards)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminDashboard == null)
            {
                return NotFound();
            }

            return View(adminDashboard);
        }

        // POST: AdminDashboards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminDashboard = await _context.AdminDashboard.FindAsync(id);
            if (adminDashboard != null)
            {
                _context.AdminDashboard.Remove(adminDashboard);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminDashboardExists(int id)
        {
            return _context.AdminDashboard.Any(e => e.Id == id);
        }
    }
}
