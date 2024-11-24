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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserInfoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public User CurrentUser { get; set; }
        public List<User> Users { get; set; } = new List<User>(); // Lista a felhasználók tárolásához

        public MainWindow()
        {
            InitializeComponent();
            CurrentUser = new User();
            DataContext = CurrentUser; // A DataContext-et az aktuális felhasználóhoz kötjük
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Hozzáadjuk az aktuális felhasználót a listához
            Users.Add(new User
            {
                UserName = CurrentUser.UserName,
                UserAge = CurrentUser.UserAge,
                UserEmail = CurrentUser.UserEmail
            });

            MessageBox.Show("Adatok elmentve!");
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            var displayWindow = new DisplayWindow(Users); // Átadjuk a felhasználók listáját
            displayWindow.Show();
        }
    }
}
