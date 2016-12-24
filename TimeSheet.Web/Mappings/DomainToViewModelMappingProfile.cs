using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TimeSheet.Model;
using TimeSheet.Web.Models;

namespace TimeSheet.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Project, ProjectViewModel>();
            CreateMap<ProjectTask, ProjectTaskViewModel>();
        }

        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

    }
}