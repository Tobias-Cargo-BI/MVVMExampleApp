using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        }

        public void Clear()
        {
            BoundText = "";
        }



    }
}