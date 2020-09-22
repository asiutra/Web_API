using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RESTfulAPI_CarService.Models;

namespace RESTfulAPI_CarService.Context
{
    public class CarServiceContext : DbContext
    {
        public CarServiceContext(DbContextOptions<CarServiceContext> options) : base(options) {  }
        
        public DbSet<CarService> CarServices { get; set; }
    }
}
