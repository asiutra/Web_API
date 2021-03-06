﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTfulAPI_CarService.Dtos.CarService;
using RESTfulAPI_CarService.Models;
using RESTfulAPI_CarService.Service;
using RESTfulAPI_CarService.Service.Interfaces;

namespace RESTfulAPI_CarService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbCarServiceController : ControllerBase
    {
        private ICarServiceService _carServiceService;
        private IRepository repo;

        public DbCarServiceController(ICarServiceService carServiceService, IRepository repo)
        {
            this._carServiceService = carServiceService;
            this.repo = repo;
        }

        // Get from Dummy data
        //[HttpGet("{id}")]
        //public IEnumerable<CarService> GetSngle(int id)
        //{
        //    return repo.CarServices.Where(x => x.Id == id);
        //}


        // api/DbCarService/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var records = await _carServiceService.GetAllAsync();
            return Ok(records);
        }

        // api/DbCarService/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            var record = await _carServiceService.GetAsync(id);
            return Ok(record);
        }

        // api/DbCarService/Add
        [HttpPost("Add")]
        public async Task<IActionResult> AddRecord([FromBody]AddCarServiceDto carService)
        {
            return Ok(await _carServiceService.CreateAsync(carService));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRecord(UpdateCarServiceDto updatedCarService)
        {
            return Ok(await _carServiceService.UpdateAsync(updatedCarService));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecord(int id)
        {
            ServiceResponse<GetCarServiceDto> response = await _carServiceService.DeleteAsync(id);
            if (response.Data == null)
                return NotFound(response);

            return Ok(response);
        }

    }
}