using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPI_CarService.Models;

namespace RESTfulAPI_CarService.Service.Interfaces
{
    public interface ICarServiceService
    {
        Task<bool> CreateAsync(CarService carService);
        Task<CarService> GetAsync(int id);
        Task<IEnumerable<CarService>> GetAllAsync();
        Task<bool> UpdateAsync(CarService carService);
        Task<bool> DeleteAsync(int id);
    }
}
