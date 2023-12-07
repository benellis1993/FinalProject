using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FinalProject.Models;

namespace FinalProject.Pages.Musicians
{
    public class CreateModel : PageModel
    {
        private readonly FinalProject.Models.MusicianDbContext _context;

        public CreateModel(FinalProject.Models.MusicianDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Musician? Musician { get; set; }

        [BindProperty]
        public Instrument? Instrument { get; set; }



        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Musician != null)
            {
                _context.Musicians.Add(Musician);
                await _context.SaveChangesAsync();
            }

            if (Instrument != null)
            {
                _context.Instruments.Add(Instrument);
                await _context.SaveChangesAsync();
            }

            // Creating a new instrument for a musician and saving it.
            if (Musician != null && Instrument != null)
            {
                MusicianInstrument musicianInstrument = new MusicianInstrument 
                {
                    Musician = Musician,
                    Instrument = Instrument
                };
                _context.MusicianInstruments.Add(musicianInstrument);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
