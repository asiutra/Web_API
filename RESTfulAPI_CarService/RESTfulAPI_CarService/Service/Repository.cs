using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTfulAPI_CarService.Models;

namespace RESTfulAPI_CarService.Service
{
    public class Repository : IRepository
    {
        private Dictionary<int, CarService> items;

        public Repository()
        {
            //Prepare some data on start.
            items = new Dictionary<int, CarService>();
            new List<CarService>
            {
                new CarService { Id = 1, Price = "150", WhatService = "Lacznik stabilizatora", When = "12.09.2020"},
                new CarService { Id = 1, Price = "150", WhatService = "Lacznik stabilizatora", When = "12.09.2020"},
                new CarService { Id = 1, Price = "150", WhatService = "Lacznik stabilizatora", When = "12.09.2020"}
            }.ForEach(cs => AddCarService(cs));
        }

        public IEnumerable<CarService> CarServices => items.Values;
        public CarService this[int id] => items.ContainsKey(id) ? items[id] : null;

        public CarService AddCarService(CarService carService)
        {
            if(carService.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; }
                carService.Id = key;
            }

            items[carService.Id] = carService;
            return carService;
        }

        public CarService UpdateCarService(CarService carService) => AddCarService(carService);

        public void DeleteCarService(int id) => items.Remove(id);
    }
}
