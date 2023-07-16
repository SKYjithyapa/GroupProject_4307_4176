using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupProject.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace GroupProject.ViewModel
{
    public partial class AdminWindowVM : ObservableObject
    {
        public Admin admin { get; set; }


        public string _firstName;
        public string _lastName;
        public string _password;
        public string _username;

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
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (_username == value)
                {
                    return;
                }
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password == value)
                {
                    return;
                }
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }



        [ObservableProperty]
        public ObservableCollection<Lecturer> lectures;

        [ObservableProperty]
        public Lecturer selectedLecturer;


     

        public List<Lecturer> DatabaseLecturers { get; private set; }
        public List<Lecturer> GetLecturersByAdmin(int adminId)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                Admin admin = context.Admins.FirstOrDefault(a => a.AdminId == adminId);
                //Lecturer lecturer = context.Lecturers.FirstOrDefault(l => l.LecturerId == lecturerId);

                if (admin != null)
                {
                    List<Lecturer> lecturers = admin.Lecturers?.ToList() ?? new List<Lecturer>();
                    //List<Student> students = lecturer.Students?.ToList() ?? new List<Student>();
                    return lecturers;
                    //return students;
                }
                else
                {
                    // Handle the case when lecturer is null
                    return new List<Lecturer>();
                }
            }
        }
        [RelayCommand]
        public void Create()
        {

            int adminId = admin.AdminId;
            using (DatabaseContext context = new DatabaseContext())
            {
                Admin admin = context.Admins?.FirstOrDefault(a => a.AdminId == adminId);

                var firstname = FirstName;
                var lastname = LastName;
                var username = Username;
                var password = Password;

                if (firstname != null && lastname != null && username != null && password != null)
                {
                    context.Lecturers.Add(new Lecturer() { LecturerFirstName = firstname, LecturerLastName = lastname, LecturerUsername = username, LecturerPassword = password, AdminId = adminId, Admin = admin });
                    context.SaveChanges();
                    MessageBox.Show("Added");
                    //Lectures.Clear();
                    Read();
                }

            }
        }


        public void Read()

        {

            int adminId = admin.AdminId;

            using (DatabaseContext context = new DatabaseContext())
            {
                //Lectures.Clear();
                DatabaseLecturers = context.Lecturers.ToList();
                List<Lecturer> filteredLecturers = (from lecturer in DatabaseLecturers
                                                    join admin in context.Admins on lecturer.AdminId equals admin.AdminId
                                                    where admin.AdminId == adminId
                                                    select lecturer).ToList();
                Lectures = new ObservableCollection<Lecturer>(filteredLecturers);

            }

        }
        [RelayCommand]

        public void Update()
        {
            int adminId = admin.AdminId;


            FirstName = SelectedLecturer.LecturerFirstName;
            LastName = SelectedLecturer.LecturerLastName;
            Username = SelectedLecturer.LecturerUsername;
            Password = SelectedLecturer.LecturerPassword;

            using (DatabaseContext context = new DatabaseContext())
            {

                

                var firstname = FirstName;
                var lastname = LastName;
                var username = Username;
                var password = Password;

                if (firstname != null && lastname != null && username != null && password != null)
                {

                    Lecturer? lecturer = context.Lecturers.Find(selectedLecturer);
                    lecturer.LecturerFirstName = firstname;
                    lecturer.LecturerLastName = lastname;
                    lecturer.LecturerUsername = username;
                    lecturer.LecturerPassword = password;

                    context.SaveChanges();
                    MessageBox.Show("updated");
                    Read();
                }

            }



        }



        [RelayCommand]
        public void Test()
        {
            MessageBox.Show("test");
        }



        [RelayCommand]

        public void Delete()
        {
            int adminId = admin.AdminId;


            using (DatabaseContext context = new DatabaseContext())
            {

                

                if (selectedLecturer != null)
                {
                    Lecturer lecturer = context.Lecturers.Single(x => x.LecturerId == selectedLecturer.LecturerId);

                    context.Remove(lecturer);
                    context.SaveChanges();
                    MessageBox.Show("Deleted");
                    Read();


                }



            }



        }
    }
}
