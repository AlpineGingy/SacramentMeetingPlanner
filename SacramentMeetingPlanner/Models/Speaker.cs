namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }

        public string SpeakerName { get; set; }

        public string Topic { get; set; }

        public int SacramentMeetingId { get; set; }
    }
}
