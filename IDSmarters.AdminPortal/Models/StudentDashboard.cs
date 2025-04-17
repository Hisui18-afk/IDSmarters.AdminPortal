namespace IDSmarters.AdminPortal.Models
{
    public class StudentDashboard
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public int PreRegistrationId { get; set; }
        public PreRegistration? PreRegistrations { get; set; }

        public ICollection<StudentDetail> Students { get; set; } = new List<StudentDetail>();
        public ICollection<AdminDashboard> AdminDashoards { get; set; } = new List<AdminDashboard>();
        public ICollection<DeanDashboard> DeanDashboards { get; set; } = new List<DeanDashboard>();

    }
}
