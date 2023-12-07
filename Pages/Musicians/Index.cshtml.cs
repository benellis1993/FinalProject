using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalProject.Pages.Musicians
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.MusicianDbContext _context;

        public IndexModel(FinalProject.Models.MusicianDbContext context)
        {
            _context = context;
            Musician = new List<Musician>();
        }

        public IList<Musician> Musician { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        // Second sorting technique with a SelectList
        public SelectList SortList {get; set;} = default!;

        public async Task OnGetAsync()
        {
            if (_context.Musicians != null)
            {
                // Sorting support
                var query = _context.Musicians.Select(p => p);
                List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "FirstName Ascending", Value = "first_asc" },
                    new SelectListItem { Text = "FirstName Descending", Value = "first_desc"}
                };
                SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

                switch (CurrentSort)
                {
                    // If user selected "first_asc", modify query to sort by first name ascending order
                    case "first_asc": 
                        query = query.OrderBy(m => m.MusicianName);
                        break;
                    // If user selected "first_desc", modify query to sort by first name descending
                    case "first_desc":
                        query = query.OrderByDescending(m => m.MusicianName);
                        break;
                }

                // Retrieve just the musicians for the page we are on
                Musician = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    }
}
