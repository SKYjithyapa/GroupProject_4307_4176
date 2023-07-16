using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GroupProject.View;

namespace GroupProject.ViewModel
{
    public partial class UserLoginVM:ObservableObject
    {
        [ObservableProperty]
        public string userName;
        [ObservableProperty]
        public string password;


        [RelayCommand]
        public void Login()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                bool userLog = context.Lecturers.Any(Lecturer => Lecturer.LecturerUsername == UserName && Lecturer.LecturerPassword == Password);

                if (userLog)
                {
                    Lecturer? lecturer = context.Lecturers.FirstOrDefault(Lecturer => Lecturer.LecturerUsername == UserName);
                    UserWindowVM userWindowVM = new UserWindowVM();
                    userWindowVM._lecturer = lecturer;
                    userWindowVM.Read();                    
                    UserWindow userWindow = new UserWindow(userWindowVM);
                    userWindow.Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
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
