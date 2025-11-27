using GettingReal_DanGaming.Models;

namespace GettingReal_DanGaming.ViewModels
{
    public class EmployeeViewModel
    {
        private Employee employee;

        public int Id 
        { 
            get { return employee.Id; }
        }

        public EmployeeViewModel(Employee employee)
        {
            this.employee = employee;
        }
    }
}
