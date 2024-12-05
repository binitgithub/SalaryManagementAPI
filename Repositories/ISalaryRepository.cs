using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalaryManagementAPI.Models;

namespace SalaryManagementAPI.Repositories
{
    public interface ISalaryRepository
    {
        Task<IEnumerable<Salary>> GetAllSalariesAsync();
        Task<Salary> GetSalaryByIdAsync(int id);
        Task AddSalaryAsync(Salary salary);
        Task SaveChangesAsync();
    }
}