using GettingReal_DanGaming.Commands;
using GettingReal_DanGaming.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace GettingReal_DanGaming.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private EmployeeRepository employeeRepo;

        public LoginViewModel()
        {
            employeeRepo = new EmployeeRepository();
        }

        public CloseDialog Close { get; set; }

        public ICommand LoginCmd { get; set; } = new LoginCommand();
        public ICommand CancelLoginCmd { get; set; } = new CancelLoginCommand();

        public EmployeeViewModel EmployeeVM { get; set; }

        private string _employeeId;
        public string EmployeeId 
        {
            get { return _employeeId; } 
            set
            {
                _employeeId = value;
                OnPropertyChanged();
            } 
        }

        private string _employeePincode;
        public string EmployeePincode
        {
            get { return _employeePincode; }
            set
            {
                _employeePincode = value;
                OnPropertyChanged();
            }
        }

        public void Login()
        {
            if (!int.TryParse(EmployeeId, out int id))
            {
                EmployeeId = string.Empty;
                EmployeePincode = string.Empty;
                return;
            }

            Employee? employee = employeeRepo.Login(id, EmployeePincode);
            if (employee == null)
            {
                EmployeeId = string.Empty;
                EmployeePincode = string.Empty;
                return;
            }

            EmployeeVM = new EmployeeViewModel(employee);
            Close(true);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
