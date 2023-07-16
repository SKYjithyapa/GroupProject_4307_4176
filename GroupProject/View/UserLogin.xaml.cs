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
using GroupProject.ViewModel;
namespace GroupProject.View
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin(UserLoginVM vm)
        {
            DataContext = vm;
            InitializeComponent();
        }

        private void CloseBtnStyle_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow window = new MainWindow();
            window.Show();
        }
    }
}
