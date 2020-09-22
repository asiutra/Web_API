using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using RESTfulAPI_CarService.Models;
using RESTfulAPI_CarService.Service;

namespace RESTfulAPI_CarService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarServiceController : ControllerBase
    {
        private IRepository repository;
        public CarServiceController(IRepository repo)
        {
            this.repository = repo;
        }


        [HttpGet]
        public IEnumerable<CarService> Get()
        {
            return repository.CarServices;
        }


        [HttpGet("{id}")]
        public CarService Get(int id)
        {
            return repository[id];
        }


        [HttpPost]
        public CarService Post([FromBody] CarService cs)
        {
            return repository.AddCarService(new CarService()
            {
                Id = cs.Id,
                Price = cs.Price,
                WhatService = cs.WhatService,
                When = cs.When
            });
        }


        [HttpPut]
        public CarService Put([FromBody] CarService cs)
        {
            return repository.UpdateCarService(cs);
        }


        [HttpPatch("{id}")]
        public StatusCodeResult Patch(int id, [FromBody] JsonPatchDocument<CarService> patch)
        {
            CarService cs = Get(id);
            if (cs != null)
            {
                patch.ApplyTo(cs);
                return Ok();
            }

            return NotFound();
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteCarService(id);
        }

    }
}