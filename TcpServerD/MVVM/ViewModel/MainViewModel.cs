using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcpServerD.Core;
using TcpServerD.MVVM.Model;

namespace TcpServerD.MVVM.ViewModel
{
    internal class MainViewModel:ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public  ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set 
            {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }

        private string _message;
        public string Message 
        {
            get { return _message; }
            set 
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirsrMessage = false
                });

                Message = "";

            });

            Messages.Add(new MessageModel
            {
                Username="sadeq",
                UsernameColor="#409aff",
                ImageSource= "https://i.postimg.cc/d3T4jSqF/images.jpg",
                Message="test",
                Time=DateTime.Now,
                IsNativeOrigin=false,
                FirsrMessage=false
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "sadeq",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.postimg.cc/d3T4jSqF/images.jpg",
                    Message = "test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirsrMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "sohrab",
                    UsernameColor = "#409aff",
                    ImageSource = "https://i.postimg.cc/d3T4jSqF/images.jpg",
                    Message = "test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new MessageModel
            {
                Username = "sohrab",
                UsernameColor = "#409aff",
                ImageSource = "https://i.postimg.cc/d3T4jSqF/images.jpg",
                Message = "last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"sadeq {i}",
                    ImageSource = "https://i.postimg.cc/d3T4jSqF/images.jpg",
                    Messages = Messages
                });
            }
        }
    }
}
