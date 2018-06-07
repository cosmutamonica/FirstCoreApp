using FirstCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Data
{
    public class FirstCoreAppDBContext:DbContext
    {
        public FirstCoreAppDBContext(DbContextOptions options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurants{ get; set; }
    }
}
