using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SalaryManagementAPI.DTOs;
using SalaryManagementAPI.Models;
using SalaryManagementAPI.Repositories;

namespace SalaryManagementAPI.Services
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryRepository _repository;
        private readonly IMapper _mapper;

        public SalaryService(ISalaryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddSalaryAsync(SalaryDto salaryDto)
        {
            var salary = _mapper.Map<Salary>(salaryDto);
            await _repository.AddSalaryAsync(salary);
            await _repository.SaveChangesAsync();
        }
    }
}