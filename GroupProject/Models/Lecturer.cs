using System.Collections.Generic;

namespace GroupProject.Models
{
    public class Lecturer
    {
        public int LecturerId { get; set; }
        public string LecturerFirstName { get; set; }
        public string LecturerLastName { get; set; }
        public string LecturerUsername { get; set; }
        public string LecturerPassword { get; set; }
        public List<Student> Students { get; set; }

        public int AdminId { get; set; } // Foreign Key Property
        public Admin Admin { get; set; } // Navigation Property
        
    }
}