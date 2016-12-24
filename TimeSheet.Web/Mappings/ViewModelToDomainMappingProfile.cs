using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TimeSheet.Model;
using TimeSheet.Web.Models;

namespace TimeSheet.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        { }
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappings";
            }
        }

    }
}