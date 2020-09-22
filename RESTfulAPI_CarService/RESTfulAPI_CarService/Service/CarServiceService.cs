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


        public async Task<bool> CreateAsync(CarService carService)
        {
            _context.CarServices.Add(carService);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<CarService> GetAsync(int id)
        {
            return await _context.CarServices.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<CarService>> GetAllAsync()
        {
            return await _context.CarServices.ToListAsync();
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
