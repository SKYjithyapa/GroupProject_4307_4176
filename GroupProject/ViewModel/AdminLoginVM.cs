using CommunityToolkit.Mvvm.ComponentModel;
using GroupProject.Models;
using GroupProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.Input;
using System.Security.RightsManagement;
using GroupProject.Models;
using GroupProject.ViewModel;



namespace GroupProject
{
    public partial class AdminLoginVM : ObservableObject
    {
        [ObservableProperty]
        public string userName;
        [ObservableProperty]
        public string password;
        public Action CloseAction { get; set; }


        public AdminLoginVM()
        {
            userName = "Admin";
            password = "abcd";
        }

        [RelayCommand]
        public void LoginClicked()
        {

            using (DatabaseContext context = new DatabaseContext())
            {
                
                bool adminLog = context.Admins.Any(Admin => Admin.AdminUsername == userName && Admin.AdminPassword == password);

                if (adminLog)
                {
                    Admin? admin = context.Admins.FirstOrDefault(Admin => Admin.AdminUsername == userName);
                    AdminWindowVM adminWindowVM = new AdminWindowVM(); ;
                    adminWindowVM.admin = admin;
                    adminWindowVM.Read();
                    AdminWindow adminWindow = new AdminWindow(adminWindowVM);
                    adminWindow.Show();
                    


                    CloseAction();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }
           
            
    }
}
