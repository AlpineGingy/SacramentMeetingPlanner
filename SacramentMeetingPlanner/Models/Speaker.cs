using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Required]
        [Display(Name = "Speaker Name")]
        public string SpeakerName { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Topic { get; set; }

        public int SacramentMeetingId { get; set; }
    }
}
