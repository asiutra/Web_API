using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulAPI_CarService.Models
{
    public class CarService
    {
        public int Id { get; set; }
        public string WhatService { get; set; }
        public string When { get; set; }
        public string Price { get; set; }
    }
}
