using EmployeeWebApplication.Models;

namespace EmployeeWebApplication.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        // Implementation
        void IEmployeeRepository.Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Employee> IEmployeeRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Employee? IEmployeeRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IEmployeeRepository.Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}   