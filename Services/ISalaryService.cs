using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalaryManagementAPI.DTOs;

namespace SalaryManagementAPI.Services
{
    public interface ISalaryService
    {
        Task AddSalaryAsync(SalaryDto salaryDto);
    }
}