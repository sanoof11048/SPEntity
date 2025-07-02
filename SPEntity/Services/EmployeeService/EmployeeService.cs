using Microsoft.EntityFrameworkCore;
using SPEntity.Data;
using SPEntity.Model;

namespace SPEntity.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        { 
            _context = context;
        }
        public async Task<List<Employee>> GetAllEmp()
        {
            return await _context.Employees.FromSqlRaw("EXEC manageEmployee @Action = 'GETALL'").ToListAsync();
        }
        public async Task<bool> DeleteEmp(int id)
        {
            var result = await _context.Database.ExecuteSqlRawAsync($"EXEC manageEmployee @Action = 'DELETE', @Id={id}");
            return result > 0;
        }
        public  async Task AddEmp(Employee emp)
        {
            await _context.Database.ExecuteSqlAsync($"EXEC manageEmployee @Action = 'INSERT', @Name = {emp.Name}, @Email={emp.Email}, @Age = {emp.Age}, @Department = {emp.Department}, @Salary = {emp.Salary}");
        }

        public async Task UpdateEmp(Employee emp)
        {
            await _context.Database.ExecuteSqlAsync($"EXEC manageEmployee @Action = 'UPDATE',@Id={emp.Id}, @Name = {emp.Name}, @Email={emp.Email}, @Age = {emp.Age}, @Department = {emp.Department}, @Salary = {emp.Salary}");
        }

        public async Task UpdateEmpp(Employee emp)
        {
            await _context.Database.ExecuteSqlAsync($"EXEC manageEmployee @Action = 'UPDATE',@Id={emp.Id}, @Name = {emp.Name}, @Email={emp.Email}, @Age = {emp.Age}, @Department = {emp.Department}, @Salary = {emp.Salary}");
        }

    }
}
