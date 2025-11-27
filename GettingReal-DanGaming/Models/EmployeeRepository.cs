namespace GettingReal_DanGaming.Models
{
    public class EmployeeRepository
    {
        private List<Employee> employees;
        
        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee { Id = 1, Pincode = "1234" },
            };
        }

        public Employee? Get(int id)
        {
            Employee? result = null;
            foreach (Employee employee in employees)
            {
                if (employee.Id == id)
                {
                    result = employee;
                    break;
                }
            }

            return result;
        }

        public Employee? Login(int id, string pincode)
        {
            Employee? result = null;
            Employee? employee = Get(id);

            if (employee != null && employee.Pincode == pincode)
            {
                result = employee;
            }

            return result;
        }
    }
}
