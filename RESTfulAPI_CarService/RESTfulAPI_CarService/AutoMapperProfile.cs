using AutoMapper;
using RESTfulAPI_CarService.Dtos.CarService;
using RESTfulAPI_CarService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI_CarService
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarService, GetCarServiceDto>();
            CreateMap<AddCarServiceDto, CarService>();
        }
    }
}
