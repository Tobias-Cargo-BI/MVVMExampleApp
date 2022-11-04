using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMExampleApp.MVVMExample.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace MVVMExampleApp
{
    public class SimpleMVVMViewModel : ObservableObject
    {
        #region Observable Properties
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _id;
        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Customer> _customers;
        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands
        public RelayCommand AddCustomerCommand {get;}
        public RelayCommand DeleteCustomerCommand { get; }
        public RelayCommand LoadCustomersCommand { get; }
        #endregion

        public SimpleMVVMViewModel()
        {
            Customers = new ObservableCollection<Customer>();

            AddCustomerCommand = new RelayCommand(AddCustomer);
            DeleteCustomerCommand = new RelayCommand(DeleteCustomer);
            LoadCustomersCommand = new RelayCommand(LoadCustomers);

        }

        public void AddCustomer()
        {
            if (!int.TryParse(ID, out _))
            {
                MessageBox.Show("Could not convert ID");
                return;
            }
            Customer customer = new()
            {
                Name = this.Name,
                ID = int.Parse(this.ID)
            };
            Customers.Add(customer);
            Name = "";
            ID = "";
        }
        public void DeleteCustomer()
        {
            Customers.RemoveAt(Customers.Count - 1);
        }
        public void LoadCustomers()
        {
            Customers = new()
            {
                new(){Name = "Alice", ID=47427552},
                new(){Name = "Bob", ID=98414564},
                new(){Name = "Christian", ID=34658465},
                new(){Name = "Dennis", ID=12458974},
                new(){Name = "Erin", ID=32689547},
            };
        }
    }
}