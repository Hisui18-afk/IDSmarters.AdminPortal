namespace IDSmarters.AdminPortal.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public ICollection<PreRegistration>? PreRegistrations { get; set; }
    }
}
