namespace GroupProject.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public char Grade { get; set; }
        public Lecturer ModuleCoordinator { get; set; }

        public int StudentId { get; set; } // Foreign key property
        public Student Student { get; set; } // Navigation property
    }
}