namespace IDSmarters.AdminPortal.Models
{
    public class InstructorDashboard
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int TotalStudents { get; set; }
        public int StudentDashboardId { get; set; }
        public StudentDashboard? StudentDashboards { get; set; }
        public int InstructorDetailId { get; set; }
        public InstructorsDetail? InstructorDetails { get; set; }
        public ICollection<AdminDashboard> AdminDashoards { get; set; } = new List<AdminDashboard>();
        public ICollection<DeanDashboard> DeanDashboards { get; set; } = new List<DeanDashboard>();
    }
}
