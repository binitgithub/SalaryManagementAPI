using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalaryManagementAPI.Data;
using SalaryManagementAPI.Models;

namespace SalaryManagementAPI.Repositories
{
    public class SalaryRepository : ISalaryRepository
    {
        private readonly AppDbContext _context;

        public SalaryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddSalaryAsync(Salary salary)
        {
            await _context.Salaries.AddAsync(salary); 
        }

        public async Task<IEnumerable<Salary>> GetAllSalariesAsync()
        {
           return await _context.Salaries.ToListAsync();
        }

        public async Task<Salary> GetSalaryByIdAsync(int id)
        {
            return await _context.Salaries.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}