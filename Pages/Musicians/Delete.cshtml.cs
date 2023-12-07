using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Musicians
{
    public class DeleteModel : PageModel
    {
        private readonly FinalProject.Models.MusicianDbContext _context;

        public DeleteModel(FinalProject.Models.MusicianDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Musician = await _context.Musicians.FindAsync(id);

            if (Musician != null)
            {
                _context.Musicians.Remove(Musician);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
