using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTfulAPI_CarService.Context;
using RESTfulAPI_CarService.Models;
using RESTfulAPI_CarService.Service.Interfaces;

namespace RESTfulAPI_CarService.Service
{
    public class CarServiceService : ICarServiceService
    {
        private readonly CarServiceContext _context;

        public CarServiceService(CarServiceContext context)
        {
            this._context = context;
        }


        //public async Task<CarService> CreateAsync(CarService carService)
        //{
        //    await _context.CarServices.AddAsync(carService);
        //    //return _context.CarServices.Add(carService);
        //    //return await _context.SaveChangesAsync() > 0;
        //}


        public async Task<ServiceResponse<IEnumerable<CarService>>> CreateAsync(CarService carService)
        {
            ServiceResponse<IEnumerable<CarService>> serviceResponse = new ServiceResponse<IEnumerable<CarService>>();
            _context.CarServices.Add(carService);
            serviceResponse.Data = await _context.CarServices.ToListAsync();
            return serviceResponse;

            //return await _context.CarServices.ToListAsync();
        }


        public async Task<ServiceResponse<CarService>> GetAsync(int id)
        {
            ServiceResponse<CarService> serviceResponse = new ServiceResponse<CarService>();
            serviceResponse.Data = await _context.CarServices.SingleOrDefaultAsync(x => x.Id == id);
            return serviceResponse;

            //return await _context.CarServices.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<ServiceResponse<IEnumerable<CarService>>> GetAllAsync()
        {
            ServiceResponse<IEnumerable<CarService>> serviceResponse = new ServiceResponse<IEnumerable<CarService>>();
            serviceResponse.Data = await _context.CarServices.ToListAsync();
            return serviceResponse;

            //return await _context.CarServices.ToListAsync();
        }

        public async Task<bool> UpdateAsync(CarService carService)
        {
            _context.CarServices.Update(carService);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cs = _context.CarServices.SingleOrDefault(s => s.Id == id);
            if (cs == null) return false;

            _context.CarServices.Remove(cs);
            return await _context.SaveChangesAsync() > 0;

        }

    }
}
