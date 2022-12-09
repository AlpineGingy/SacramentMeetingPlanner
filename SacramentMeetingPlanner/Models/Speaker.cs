using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }

        [Display(Name = "Speaker Name")]
        public string SpeakerName { get; set; }

        public string Topic { get; set; }

        public int SacramentMeetingId { get; set; }
    }
}
