namespace IDSmarters.AdminPortal.Models
{
    public class StudentDetail
    {
        public int Id { get; set; }
        public int? EnrollmentId { get; set; }
        public Enrollment? Enrollments { get; set; }

        public int? ProgramId { get; set; }
        public DepProgram? Programs { get; set; }
        public int? CourseId { get; set; }
        public Course? Courses { get; set; }

        public int? StrandId { get; set; }
        public Strand? Strands { get; set; }

        public int? ScheduleId { get; set; }
        public Schedule? Schedules { get; set; }
    }
}
