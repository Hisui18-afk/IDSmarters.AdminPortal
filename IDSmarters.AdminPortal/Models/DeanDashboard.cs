

namespace IDSmarters.AdminPortal.Models
{
    public class DeanDashboard
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int TotalStudents { get; set; }
        public int StudentDashboardId { get; set; }
        public StudentDashboard? StudentDashboards { get; set; }
        public int InstructorDashboardId { get; set; }
        public InstructorDashboard? InstructorDashboards { get; set; }
        public ICollection<AdminDashboard> AdminDashoards { get; set; } = new List<AdminDashboard>();

    }
}
