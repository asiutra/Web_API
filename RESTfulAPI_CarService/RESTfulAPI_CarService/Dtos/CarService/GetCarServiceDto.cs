using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI_CarService.Dtos.CarService
{
    public class GetCarServiceDto
    {
        public int Id { get; set; }
        public string WhatService { get; set; }
        public string When { get; set; }
        public string Price { get; set; }
        public string RegistrationNO { get; set; }
    }
}
