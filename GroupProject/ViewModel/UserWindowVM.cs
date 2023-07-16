using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GroupProject.ViewModel
{
    public partial class UserWindowVM : ObservableObject

    {

        public Lecturer _lecturer { get; set; }
        public List<Student> DatabaseStudents { get; set; }

        [ObservableProperty]
        public ObservableCollection<Student> studentList;


        [ObservableProperty]
        public ObservableCollection<Module> moduleList;

        [ObservableProperty]
        public Student selectedStudent;

        [ObservableProperty]
        public Module selectedModule;

        public string _firstName;
        public string _lastName;
        public string _moduleCode;
        public string _moduleName;
        public string _grade;
        public string _modCoordinatorId;


        public string FirstName
        {
            get
            {
                return _firstName;

            }
            set
            {
                if (_firstName == value)
                {
                    return;
                }
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));

            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (_lastName == value)
                {
                    return;
                }
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        public string ModuleName
        {
            get
            {
                return _moduleName;
            }
            set
            {
                if (_moduleName == value)
                {
                    return;
                }
                _moduleName = value;
                OnPropertyChanged(nameof(ModuleName));
            }
        }

        public string Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (_grade == value)
                {
                    return;
                }
                _grade = value;
                OnPropertyChanged(nameof(Grade));
            }
        }

        public string ModuleCode
        {
            get
            {
                return _moduleCode;
            }
            set
            {
                if (_moduleCode == value)
                {
                    return;
                }
                _moduleCode = value;
                OnPropertyChanged(nameof(ModuleCode));
            }
        }


        public string ModCoordintorId
        {
            get
            {
                return _modCoordinatorId;
            }
            set
            {
                if (_modCoordinatorId == value)
                {
                    return;
                }
                _modCoordinatorId = value;
                OnPropertyChanged(nameof(ModCoordintorId));
            }
        }


        public void Read()
        {

            int LecId = _lecturer.LecturerId;
            using (DatabaseContext context = new DatabaseContext())
            {
                DatabaseStudents = context.Students.ToList();
                List<Student> filteredStudents = (from student in DatabaseStudents
                                                  join lecturer in context.Lecturers on student.LecturerId equals lecturer.LecturerId
                                                  where lecturer.LecturerId == LecId
                                                  select student).ToList();
                studentList = new ObservableCollection<Student>(filteredStudents);
            }

        }

        public List<Module> DatabaseModules { get; private set; }
        public void ReadModules()
        {
            //Student? selectedStudent = SelectedStudent;
            using (DatabaseContext context = new DatabaseContext())
            {
                moduleList.Clear();
                DatabaseModules = context.Modules.ToList();

                List<Module> filteredModules = (from module in DatabaseModules
                                                join student in context.Students on module.StudentId equals student.StudentId
                                                where student.StudentId == selectedStudent.StudentId
                                                select module)
                                                .ToList();

                moduleList = new ObservableCollection<Module>(filteredModules);
            }
        }

        public List<Student> GetStudentsByLecturer()
        {
            int lecturerId = _lecturer.LecturerId;
            using (DatabaseContext context = new DatabaseContext())
            {
                Lecturer lecturer = context.Lecturers.FirstOrDefault(l => l.LecturerId == lecturerId);

                if (lecturer != null)
                {
                    List<Student> students = lecturer.Students?.ToList() ?? new List<Student>();
                    return students;
                }
                else
                {
                    // Handle the case when lecturer is null
                    return new List<Student>();
                }
            }
        }




        public double CalcGPA()
        {

            //Student? selectedStudent = sele
            using (DatabaseContext context = new DatabaseContext())
            {
                double Gpa;
                int totCredit = 0;
                double gradePoint;
                double totGradePoint = 0;
                DatabaseModules = context.Modules.ToList();
                List<Module> filteredModules = (from module in DatabaseModules
                                                join student in context.Students on module.StudentId equals student.StudentId
                                                where student.StudentId == selectedStudent.StudentId
                                                select module).ToList();
                foreach (Module module in filteredModules)
                {
                    int credit = int.Parse(module.ModuleCode[3].ToString());
                    totCredit = totCredit + credit;



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
                            break;
                        default:
                            gradePoint = 0.00;
                            break;
                    }

                    totGradePoint = totGradePoint + (gradePoint * credit);

                }
                Gpa = totGradePoint / totCredit;
                selectedStudent.GPA = Gpa;
                return Gpa;
            }
        }



        public void Create()
        {
            int LecId = _lecturer.LecturerId;
            using (DatabaseContext context = new DatabaseContext())
            {
                Lecturer lecturer = context.Lecturers?.FirstOrDefault(l => l.LecturerId == LecId);
                //List<Student> studentList = GetStudentsByLecturer(LecId);

                DatabaseStudents = context.Students.ToList();
                List<Student> filteredStudents = (from student in DatabaseStudents
                                                  join l in context.Lecturers on student.LecturerId equals l.LecturerId
                                                  where l.LecturerId == LecId
                                                  select student).ToList();

                var firstname = FirstName;
                var lastname = LastName;
                //var gpa = GPATextBox.Text;

                if (firstname != null && lastname != null)
                {
                    Student newStudent = new Student() { StudentFirstName = firstname, StudentLastName = lastname, LecturerId = LecId, Lecturer = lecturer, GPA = 0.00 };
                    filteredStudents.Add(newStudent);
                    context.Students.Add(newStudent);
                    context.SaveChanges();
                }
            }

        }


        public void CreateModule()
        {
            //Student? selectedStudent = StudentList.SelectedItem as Student;
            using (DatabaseContext context = new DatabaseContext())
            {
                DatabaseModules = context.Modules.ToList();
                List<Module> filteredModules = (from module in DatabaseModules
                                                join student in context.Students on module.StudentId equals student.StudentId
                                                where student.StudentId == selectedStudent.StudentId
                                                select module).ToList();
                var moduleCode = ModuleCode;
                var moduleName = ModuleName;
                var grade = Grade;
                var modCoordinatorId = ModCoordintorId;
                int modCoordId = int.Parse(modCoordinatorId);
                Lecturer? moduleCoordinator = context.Lecturers?.FirstOrDefault(l => l.LecturerId == modCoordId);
                if (moduleCode != null && moduleName != null && grade != null && modCoordinatorId != null)
                {
                    Module newModule = new Module()
                    {
                        ModuleCode = moduleCode,
                        ModuleName = moduleName,
                        Grade = char.Parse(grade),
                        ModuleCoordinator = moduleCoordinator,
                        Student = selectedStudent,
                        StudentId = selectedStudent.StudentId
                    };
                    var freshStudent = context.Students.Find(selectedStudent.StudentId);
                    newModule.Student = freshStudent;
                    newModule.StudentId = freshStudent.StudentId;

                    filteredModules.Add(newModule);
                    context.Modules.Add(newModule);
                    context.SaveChanges();
                }
            }
        }
        public void Update()
        {
            int LecId = _lecturer.LecturerId;

            //List<Student> studentList = GetStudentsByLecturer(LecId);

            using (DatabaseContext context = new DatabaseContext())
            {

                //Student? selectedStudent = StudentList.SelectedItem as Student;

                var firstname = FirstName;
                var lastname = LastName;
                //var gpa = GPATextBox.Text;

                if (firstname != null && lastname != null)
                {
                    Student? student = context.Students.Find(selectedStudent.StudentId);
                    student.StudentFirstName = firstname;
                    student.StudentLastName = lastname;
                    student.GPA = 0.00;

                    context.SaveChanges();
                }

            }
        }

        public void EditModule()
        {
            //Module? selectedModule = ModuleList.SelectedItem as Module;
            using (DatabaseContext context = new DatabaseContext())
            {
                var moduleCode = ModuleCode;
                var moduleName = ModuleName;
                var grade = Grade;
                var modCoordinatorId = ModCoordintorId;
                int modCoordId = int.Parse(modCoordinatorId);
                Lecturer? moduleCoordinator = context.Lecturers?.FirstOrDefault(l => l.LecturerId == modCoordId);
                if (selectedModule != null && moduleCode != null && moduleName != null && grade != null && modCoordinatorId != null)
                {
                    Module? module = context.Modules.Find(selectedModule.ModuleId);
                    module.ModuleCode = moduleCode;
                    module.ModuleName = moduleName;
                    module.Grade = char.Parse(grade);
                    module.ModuleCoordinator = moduleCoordinator;

                    context.SaveChanges();
                }
            }
        }

        public void Delete()
        {
            int LecId = _lecturer.LecturerId;
            //List<Student> studentList = GetStudentsByLecturer(LecId);


            using (DatabaseContext context = new DatabaseContext())
            {
                DatabaseStudents = context.Students.ToList();
                List<Student> filteredStudents = (from student in DatabaseStudents
                                                  join l in context.Lecturers on student.LecturerId equals l.LecturerId
                                                  where l.LecturerId == LecId
                                                  select student).ToList();
                //Student? selectedStudent = StudentList.SelectedItem as Student;

                if (selectedStudent != null)
                {

                    context.Students.Remove(context.Students.Find(selectedStudent.StudentId));
                    filteredStudents.Remove(selectedStudent);

                    context.SaveChanges();
                }
            }
        }

        public void RemoveModule()
        {
            //Student? selectedStudent = StudentList.SelectedItem as Student;
            //Module? selectedModule = ModuleList.SelectedItem as Module;
            using (DatabaseContext context = new DatabaseContext())
            {
                if (selectedStudent != null && selectedModule != null)
                {
                    context.Modules.Remove(context.Modules.Find(selectedModule.ModuleId));
                    context.SaveChanges();
                }
            }
        }

        [RelayCommand]
        public void CreateBtn()
        {
            Create();
            Read();
        }

        [RelayCommand]
        public void UpdateBtn()
        {
            Update();
            Read();
        }

        [RelayCommand]

        public void DeleteBtn()
        {
            Delete();
            Read();
        }

        [RelayCommand]

        public void ClearBtn()
        {
            studentList.Clear();
        }


        [RelayCommand]
        public void AddModuleBtn()
        {
            CreateModule();
            ReadModules();
        }

        [RelayCommand]
        public void CalcGPABtn()
        {
            double gpa = CalcGPA();
            MessageBox.Show($"GPA is {gpa}");
        }

        [RelayCommand]

        public void EditModuleBtn()
        {
            EditModule();
            ReadModules();
        }

        [RelayCommand]

        public void RemoveModuleBtn()
        {
            RemoveModule();
            ReadModules();
        }

        [RelayCommand]
        public void LogoutBtn()
        {
            {
                MainWindow window = new MainWindow();
                window.Show();
                Close();

            }


        }
        [RelayCommand]

        public void ShowModules()
        {
            ReadModules();
        }


        public void Close()
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }
        }
    }
}
