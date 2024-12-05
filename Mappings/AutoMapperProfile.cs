using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SalaryManagementAPI.DTOs;
using SalaryManagementAPI.Models;

namespace SalaryManagementAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SalaryDto, Salary>()
                .ForMember(dest => dest.NetSalary, opt => opt.MapFrom(src => 
                    src.BaseSalary + src.Allowances - src.Deductions))
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(_ => DateTime.Now));
        }
    }
}