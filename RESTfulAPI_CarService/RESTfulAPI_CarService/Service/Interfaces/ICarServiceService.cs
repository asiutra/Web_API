using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPI_CarService.Dtos.CarService;
using RESTfulAPI_CarService.Models;

namespace RESTfulAPI_CarService.Service.Interfaces
{
    public interface ICarServiceService
    {
        Task <ServiceResponse<IEnumerable<GetCarServiceDto>>> CreateAsync(AddCarServiceDto carService);
        Task <ServiceResponse<GetCarServiceDto>> GetAsync(int id);
        Task <ServiceResponse<IEnumerable<GetCarServiceDto>>> GetAllAsync();
        Task<ServiceResponse<GetCarServiceDto>> UpdateAsync(UpdateCarServiceDto updatedCarService);
        Task<ServiceResponse<GetCarServiceDto>> DeleteAsync(int id);
    }
}
