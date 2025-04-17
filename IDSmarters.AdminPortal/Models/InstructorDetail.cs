namespace IDSmarters.AdminPortal.Models
{
    public class InstructorsDetail
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public DepProgram? Programs { get; set; }
        public int Strand { get; set; }
        public Strand? Strands { get; set; }
        public int ScheduleId { get; set; }
        public Schedule? Schedules { get; set; }
        public int PreRegistrationId { get; set; }
        public PreRegistration? PreRegistrations { get; set; }
        public ICollection<InstructorDashboard>? InstructorDashboards { get; set; }

    }
}
