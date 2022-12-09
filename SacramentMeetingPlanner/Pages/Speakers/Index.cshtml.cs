using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public IndexModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string MeetingId { get; set; }

        public IList<Speaker> Speaker { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var speaker = from s in _context.Speaker
                          select s;
            if (!string.IsNullOrEmpty(MeetingId))
            {
                speaker = speaker.Where(s => s.SacramentMeetingId == (int.Parse(MeetingId)));
            }

            if (_context.Speaker != null)
            {
                Speaker = await speaker.ToListAsync();
            }
        }
    }
}
