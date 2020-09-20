using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPI_CarService.Models;

namespace RESTfulAPI_CarService.Service
{
    interface IRepository
    {
        IEnumerable<CarService> CarServices { get; }
        CarService this[int id] { get; }
        CarService AddCarService(CarService carService);
        CarService UpdateCarService(CarService carService);
        void DeleteCarService(int id);

    }
}
