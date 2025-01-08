using AntdUI;

namespace SprayProcessSystem.UI.Models
{

    public class User: NotifyProperty
    {
        public string Password { get; set; }
        public int Id { get; set; }

        private bool _isSelected;
        private string _userName;
        private string _nickName;
        private string _role;
        private DateTime _createdAt;
        private bool _isEnabled;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string NickName
        {
            get => _nickName;
            set
            {
                _nickName = value;
                OnPropertyChanged();
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged();
            }
        }

        public DateTime CreatedAt
        {
            get => _createdAt;
            set
            {
                _createdAt = value;
                OnPropertyChanged();
            }
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

    }
}
