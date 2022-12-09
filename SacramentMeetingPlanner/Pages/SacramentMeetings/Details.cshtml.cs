using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.SacramentMeetings
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public DetailsModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public SacramentMeeting SacramentMeeting { get; set; }


        [BindProperty]
        public IQueryable<Speaker> Speakers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.SacramentMeeting == null)
            {
                return NotFound();
            }

            var sacramentmeeting = await _context.SacramentMeeting
                .Include(h => h.OpeningHymn)
                .Include(h => h.SacramentalHymn)
                .Include(h => h.IntermediateHymn)
                .Include(h => h.ClosingHymn)
                .FirstOrDefaultAsync(m => m.SacramentMeetingId == id);

            var speakers = from s in _context.Speaker
                           select s;
            speakers = speakers.Where(s => s.SacramentMeetingId == id);
            Speakers = speakers;


            if (sacramentmeeting == null)
            {
                return NotFound();
            }
            else 
            {
                SacramentMeeting = sacramentmeeting;
            }
            return Page();
        }
    }
}
