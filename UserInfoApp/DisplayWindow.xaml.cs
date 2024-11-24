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

namespace UserInfoApp
{
    /// <summary>
    /// Interaction logic for DisplayWindow.xaml
    /// </summary>
    public partial class DisplayWindow : Window
    {
        private List<User> _users; // Tárolja az összes felhasználót

        public DisplayWindow(List<User> users)
        {
            InitializeComponent();
            _users = users;
            DisplayListBox.ItemsSource = _users; // A ListBox adatforrása a felhasználói lista
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // A kiválasztott felhasználót töröljük a listából
            var user = (sender as FrameworkElement)?.DataContext as User;
            if (user != null)
            {
                _users.Remove(user);
                DisplayListBox.Items.Refresh(); // Frissíti a ListBox megjelenítését
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
