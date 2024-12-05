using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalaryManagementAPI.DTOs;
using SalaryManagementAPI.Repositories;
using SalaryManagementAPI.Services;

namespace SalaryManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _salaryService;
        private readonly ISalaryRepository _salaryRepository;

        public SalaryController(ISalaryService salaryService, ISalaryRepository salaryRepository)
        {
            _salaryService = salaryService;
            _salaryRepository = salaryRepository;
        }


    //Get All Salary
    [HttpGet]
    public async Task<IActionResult> GetAllSalary()
    {
        var GetSalaryModels = await _salaryRepository.GetAllSalariesAsync();
        if (GetSalaryModels == null)
        {
            return NotFound();
        }
       
        return Ok(GetSalaryModels);
    }

    //Add Salary
    [HttpPost]
    public async Task<IActionResult> AddSalary(SalaryDto salaryDto)
    {
        await _salaryService.AddSalaryAsync(salaryDto);
        return Ok("Salary added successfully!");
     }
    }
}