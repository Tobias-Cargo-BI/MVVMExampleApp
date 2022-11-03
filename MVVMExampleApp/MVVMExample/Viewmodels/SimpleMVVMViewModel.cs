using CommunityToolkit.Mvvm.ComponentModel;

namespace MVVMExampleApp
{
    public class SimpleMVVMViewModel : ObservableObject
    {
		private string _boundText;

		public string BoundText
		{
			get { return _boundText; }
			set { _boundText = value; }
		}

		public SimpleMVVMViewModel()
		{
			BoundText = "This is my text";
		}

	}
}