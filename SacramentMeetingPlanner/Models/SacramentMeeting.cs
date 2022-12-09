using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int SacramentMeetingId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string ?Presiding { get; set; }

        public string ?Conducting { get; set; }

        [Display(Name = "Opening Hymn")]
        public int OpeningHymnId { get; set; }

        public string Invocation { get; set; }

        [Display(Name = "Sacramental Hymn")]
        public int SacramentalHymnId { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public int ?IntermediateHymnId { get; set; }

        [Display(Name = "Closing Hymn")]
        public int ?ClosingHymnId { get; set; }

        public string ?Benediction { get; set; }

        // Nav Properties
        public Hymn OpeningHymn { get; set; }

        public Hymn SacramentalHymn { get; set; }
        public Hymn? IntermediateHymn { get; set; }
        public Hymn ClosingHymn { get; set; }

        public Speaker Speaker { get; set; }
    }
}
