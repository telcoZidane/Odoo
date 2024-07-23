using AutoMapper;
using OdooWorkerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooWorkerService.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Core.Core.Entities.HrEmployee, HrEmployee>()
            .ForMember(dest => dest.IdOdoo, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<HrEmployee, Core.Core.Entities.HrEmployee>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdOdoo != 0 ? src.IdOdoo : src.Id));
    }
}



