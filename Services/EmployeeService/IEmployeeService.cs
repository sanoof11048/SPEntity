using SPEntity.Model;

namespace SPEntity.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmp();
        Task<bool> DeleteEmp(int id);
        Task AddEmp(Employee emp);
        Task UpdateEmp(Employee emp);
    }
}
