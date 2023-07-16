using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using GroupProject.View;
using GroupProject.ViewModel;

namespace GroupProject
{
    public partial class MainWindowVM :ObservableObject
    {



        [RelayCommand]
        public void openAdminLogin()
        {
            AdminLogin window = new AdminLogin();
            window.Show();
            Application.Current.MainWindow.Close();
        }

        [RelayCommand]
        public void openUserLogin()
        {
            UserLoginVM vm = new UserLoginVM();
            UserLogin window = new UserLogin(vm);
            window.Show();
            Application.Current.MainWindow.Close();
        }




    }
}
