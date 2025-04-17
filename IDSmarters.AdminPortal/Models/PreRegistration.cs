namespace IDSmarters.AdminPortal.Models
{
    public class PreRegistration
    {
        public int Id { get; set; }
        public int StudNum { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Mname { get; set; }
        public string? Sname { get; set; }
        public string? Email { get; set; }
        public string? Number { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Purok { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Municipality { get; set; }
        public string? LastSchool { get; set; }
        public string? Address { get; set; }
        public string? Nationality { get; set; }
        public string? Religion { get; set; }
        public string? ProfilePic { get; set; }

        // Medical Information
        public string? MedicalCondition { get; set; }
        public string? Allergies { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhone { get; set; }

        // Document paths
        public string? Document1 { get; set; }
        public string? Document2 { get; set; }
        public string? Document3 { get; set; }
        public string? Document4 { get; set; }

        public ICollection<StudentDetail> Students { get; set; } = new List<StudentDetail>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<StudentDashboard> StudentDashboards { get; set; } = new List<StudentDashboard>();
    }
}
