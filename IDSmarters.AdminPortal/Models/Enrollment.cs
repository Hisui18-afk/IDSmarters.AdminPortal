namespace IDSmarters.AdminPortal.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public string? StudNumber { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance => Amount - AmountPaid;
        public DateTime? PaymentDate { get; set; }
        public string? PaymentReference { get; set; }

        public string? Semester { get; set; }
        public int AcademicYear { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }
        public int PreRegistrationId { get; set; }
        public PreRegistration? PreRegistration { get; set; }
    }
}
