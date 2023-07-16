using System.Collections.Generic;


namespace GroupProject.Models
{
    public class Student
    {
        

        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public List<Module> Modules { get; set; }
        public double GPA { get; set; }

        public int LecturerId { get; set; } // Foreign Key Property
        public Lecturer Lecturer { get; set; } // Navigation Property


        public double CalcGPA()
        {

            //Student? selectedStudent = sele
    
                double Gpa;
                int totCredit = 0;
                double gradePoint;
                double totGradePoint = 0;
                
                foreach (Module module in Modules)
                {
                    int credit = int.Parse(module.ModuleCode[3].ToString());



                    switch (module.Grade)
                    {
                        case 'A':
                            gradePoint = 4.00;
                            break;
                        case 'B':
                            gradePoint = 3.00;
                            break;
                        case 'C':
                            gradePoint = 2.00;
                            break;
                        case 'D':
                            gradePoint = 1.00;
                            break;
                        case 'E':
                            gradePoint = 0.00;
                        credit = 0;
                            break;
                        default:
                            gradePoint = 0.00;
                        credit = 0;

                        break;
                    }
                totCredit = totCredit + credit;

                if (gradePoint>0)
                {
                    totGradePoint = totGradePoint + (gradePoint * credit);

                }

                }
            if (totGradePoint > 0)
            {

                Gpa = totGradePoint / totCredit;

            }
            else
            {
                Gpa = 0.0;
            }
                //selectedStudent.GPA = Gpa;
                return Gpa;
            
        }
    }
}