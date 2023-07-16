using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GroupProject
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
/*
        TextBox textBoxUser = ;
        TextBox textBoxPass = Admin_Password;*/
        public AdminLogin()
        {
            
            InitializeComponent();
            AdminLoginVM vm = new AdminLoginVM();
            DataContext = vm;
            if(vm.CloseAction == null)
                vm.CloseAction = new Action(() => this.Close());   

            /*textBoxUser.GotFocus += GotFocus.EventHandle(RemoveText);
            textBoxUser.LostFocus += LostFocus.EventHandle(AddText);*/

            
        }

       /* public void RemoveText(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Enter text here...")
            {
                textBoxUser.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUser.Text))
                textBoxUser.Text = "Enter text here...";
        }*/


    }
}
