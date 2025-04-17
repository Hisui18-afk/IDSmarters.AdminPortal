namespace IDSmarters.AdminPortal.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string? Day { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string? Room { get; set; }
        public ICollection<PreRegistration>? PreRegistrations { get; set; }
    }
}
