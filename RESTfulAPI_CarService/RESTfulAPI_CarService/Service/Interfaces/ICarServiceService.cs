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
        //Task<bool> CreateAsync(CarService carService);
        Task <ServiceResponse<IEnumerable<GetCarServiceDto>>> CreateAsync(AddCarServiceDto carService);
        Task <ServiceResponse<GetCarServiceDto>> GetAsync(int id);
        Task <ServiceResponse<IEnumerable<GetCarServiceDto>>> GetAllAsync();

        
        //change two Interface return type to CarService and add ServiceResponse
        //Task <bool> UpdateAsync(AddCarServiceDto carService); 
        //Task <bool> DeleteAsync(int id);
    }
}
