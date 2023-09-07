using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectManagment.DATA.EF.Models;

namespace ProjectManagment.UI.MVC.Controllers
{
    public class ProjectManagersController : Controller
    {
        private readonly ProjectManagerContext _context;

        public ProjectManagersController(ProjectManagerContext context)
        {
            _context = context;
        }

        // GET: ProjectManagers
        public async Task<IActionResult> Index()
        {
              return _context.ProjectManagers != null ? 
                          View(await _context.ProjectManagers.ToListAsync()) :
                          Problem("Entity set 'ProjectManagerContext.ProjectManagers'  is null.");
        }

        // GET: ProjectManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjectManagers == null)
            {
                return NotFound();
            }

            var projectManager = await _context.ProjectManagers
                .FirstOrDefaultAsync(m => m.ProjectManagerId == id);
            if (projectManager == null)
            {
                return NotFound();
            }

            return View(projectManager);
        }

        // GET: ProjectManagers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectManagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectManagerId,FirstName,LastName,Email")] ProjectManager projectManager)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectManager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectManager);
        }

        // GET: ProjectManagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjectManagers == null)
            {
                return NotFound();
            }

            var projectManager = await _context.ProjectManagers.FindAsync(id);
            if (projectManager == null)
            {
                return NotFound();
            }
            return View(projectManager);
        }

        // POST: ProjectManagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectManagerId,FirstName,LastName,Email")] ProjectManager projectManager)
        {
            if (id != projectManager.ProjectManagerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectManager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectManagerExists(projectManager.ProjectManagerId))
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
            return View(projectManager);
        }

        // GET: ProjectManagers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjectManagers == null)
            {
                return NotFound();
            }

            var projectManager = await _context.ProjectManagers
                .FirstOrDefaultAsync(m => m.ProjectManagerId == id);
            if (projectManager == null)
            {
                return NotFound();
            }

            return View(projectManager);
        }

        // POST: ProjectManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjectManagers == null)
            {
                return Problem("Entity set 'ProjectManagerContext.ProjectManagers'  is null.");
            }
            var projectManager = await _context.ProjectManagers.FindAsync(id);
            if (projectManager != null)
            {
                _context.ProjectManagers.Remove(projectManager);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectManagerExists(int id)
        {
          return (_context.ProjectManagers?.Any(e => e.ProjectManagerId == id)).GetValueOrDefault();
        }
    }
}
