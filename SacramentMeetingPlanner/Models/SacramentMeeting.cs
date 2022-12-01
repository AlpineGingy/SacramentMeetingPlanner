using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int SacramentMeetingId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Presiding { get; set; }

        public string Conducting { get; set; }

        [Display(Name = "Opening Hymn")]
        public Hymn OpeningHymn { get; set; }

        public string Invocation { get; set; }

        [Display(Name = "Sacramental Hymn")]
        public Hymn SacramentalHymn { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public Hymn IntermediateHymn { get; set; }

        [Display(Name = "Closing Hymn")]
        public Hymn ClosingHymn { get; set; }

        public string Benediction { get; set; } 

    }
}
