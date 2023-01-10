using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

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

        public RelayCommand ClearTextCommand { get; }

        public SimpleMVVMViewModel()
        {
            BoundText = "This is my text";
        }

        public void Clear()
        {
            BoundText = "";
        }

    }
}