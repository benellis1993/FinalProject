using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Musicians
{
    public class EditModel : PageModel
    {
        private readonly FinalProject.Models.MusicianDbContext _context;

        public EditModel(FinalProject.Models.MusicianDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Musician? Musician { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Musician = await _context.Musicians.FirstOrDefaultAsync(m => m.MusicianId == id);

            if (Musician == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Musician == null)
            {
                return NotFound();
            }

            _context.Attach(Musician).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MusicianExists(Musician.MusicianId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MusicianExists(int id)
        {
            return _context.Musicians.Any(e => e.MusicianId == id);
        }
    }
}
