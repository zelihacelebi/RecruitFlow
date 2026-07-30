using AutoMapper;
using RecruitFlow.Application.DTOs;
using RecruitFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitFlow.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Department
            CreateMap<Department, DepartmentDto>();
            CreateMap<CreateDepartmentDto, Department>();
            CreateMap<UpdateDepartmentDto, Department>();

            // JobPosition
            CreateMap<JobPosition, JobPositionDto>();
            CreateMap<CreateJobPositionDto, JobPosition>();
            CreateMap<UpdateJobPositionDto, JobPosition>();

            // Candidate
            CreateMap<Candidate, CandidateDto>();
            CreateMap<CreateCandidateDto, Candidate>();
            CreateMap<UpdateCandidateDto, Candidate>(); 
        }
    }
}
