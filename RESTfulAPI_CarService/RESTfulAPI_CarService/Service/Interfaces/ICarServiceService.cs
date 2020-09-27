using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPI_CarService.Models;

namespace RESTfulAPI_CarService.Service.Interfaces
{
    public interface ICarServiceService
    {
        //Task<bool> CreateAsync(CarService carService);
        Task <ServiceResponse<IEnumerable<CarService>>> CreateAsync(CarService carService);
        Task <ServiceResponse<CarService>> GetAsync(int id);
        Task <ServiceResponse<IEnumerable<CarService>>> GetAllAsync();

        
        //change two Interface return type to CarService and add ServiceResponse
        Task <bool> UpdateAsync(CarService carService); 
        Task <bool> DeleteAsync(int id);
    }
}
