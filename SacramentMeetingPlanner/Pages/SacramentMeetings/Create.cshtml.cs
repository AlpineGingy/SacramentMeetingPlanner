using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.SacramentMeetings
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public CreateModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }



        public IActionResult OnGet()
        {
            ViewData["HymnId"] = new SelectList(_context.Set<Hymn>(), "HymnId", "HymnTitle");
            return Page();
        }

        [BindProperty]
        public SacramentMeeting SacramentMeeting { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          //if (!ModelState.IsValid)
          //  {
          //      return Page();
          //  }

            _context.SacramentMeeting.Add(SacramentMeeting);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Speakers/Index", new { MeetingId = SacramentMeeting.SacramentalHymnId });
        }
    }
}
