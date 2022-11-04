using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMExampleApp.MVVMExample.Models;
using System.Collections.ObjectModel;

namespace MVVMExampleApp
{
    public class SimpleMVVMViewModel : ObservableObject
    {
        private string _boundText;

        public string BoundText
        {
            get { return _boundText; }
            set
            {
                _boundText = value;
                OnPropertyChanged();
            }
        }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
            }
        }

        public ObservableCollection<string> BoundCollection { get; set; }

        public RelayCommand ClearTextCommand { get; }


        public SimpleMVVMViewModel()
        {
            BoundText = "This is my text";
            ClearTextCommand = new RelayCommand(Clear);
            BoundCollection = new ObservableCollection<string>()
            {
                "This","Is","An","Observed","Collection"
            };
            Customer = new Customer()
            {
                Name = "Jonathan Smith",
                ID = 123456789
            };
        }

        public void Clear()
        {
            BoundText = "";
        }



    }
}