using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace UserInfoApp
{
    public class User : INotifyPropertyChanged
    {
        private string userName;
        private int userAge;
        private string userEmail;

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public int UserAge
        {
            get => userAge;
            set
            {
                userAge = value;
                OnPropertyChanged(nameof(UserAge));
            }
        }

        public string UserEmail
        {
            get => userEmail;
            set
            {
                userEmail = value;
                OnPropertyChanged(nameof(UserEmail));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
