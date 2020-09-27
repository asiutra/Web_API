using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RESTfulAPI_CarService.Context;
using RESTfulAPI_CarService.Dtos.CarService;
using RESTfulAPI_CarService.Models;
using RESTfulAPI_CarService.Service.Interfaces;

namespace RESTfulAPI_CarService.Service
{
    public class CarServiceService : ICarServiceService
    {
        private readonly CarServiceContext _context;
        private readonly IMapper _mapper;

        public CarServiceService(CarServiceContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }


        //public async Task<CarService> CreateAsync(CarService carService)
        //{
        //    await _context.CarServices.AddAsync(carService);
        //    //return _context.CarServices.Add(carService);
        //    //return await _context.SaveChangesAsync() > 0;
        //}


        public async Task<ServiceResponse<IEnumerable<GetCarServiceDto>>> CreateAsync(AddCarServiceDto carService)
        {
            ServiceResponse<IEnumerable<GetCarServiceDto>> serviceResponse = new ServiceResponse<IEnumerable<GetCarServiceDto>>();
            _context.CarServices.Add(_mapper.Map<CarService>(carService));
            serviceResponse.Data = (await _context.CarServices.Select(c => _mapper.Map<GetCarServiceDto>(c)).ToListAsync());
            return serviceResponse;

            //return await _context.CarServices.ToListAsync();
        }


        public async Task<ServiceResponse<GetCarServiceDto>> GetAsync(int id)
        {
            ServiceResponse<GetCarServiceDto> serviceResponse = new ServiceResponse<GetCarServiceDto>();
            serviceResponse.Data = _mapper.Map<GetCarServiceDto>(await _context.CarServices.SingleOrDefaultAsync(x => x.Id == id));
            return serviceResponse;

            //return await _context.CarServices.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<ServiceResponse<IEnumerable<GetCarServiceDto>>> GetAllAsync()
        {
            ServiceResponse<IEnumerable<GetCarServiceDto>> serviceResponse = new ServiceResponse<IEnumerable<GetCarServiceDto>>();
            serviceResponse.Data = (await _context.CarServices.Select(c => _mapper.Map<GetCarServiceDto>(c)).ToListAsync());
            return serviceResponse;

            //return await _context.CarServices.ToListAsync();
        }




        //public async Task<bool> UpdateAsync(AddCarServiceDto carService)
        //{
        //    _context.CarServices.Update(carService);
        //    return await _context.SaveChangesAsync() > 0;
        //}

        //public async Task<bool> DeleteAsync(int id)
        //{
        //    var cs = _context.CarServices.SingleOrDefault(s => s.Id == id);
        //    if (cs == null) return false;

        //    _context.CarServices.Remove(cs);
        //    return await _context.SaveChangesAsync() > 0;

        //}

    }
}
