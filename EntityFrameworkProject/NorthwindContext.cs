﻿using RecapProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject1
{
    public class NorthwindContext : DbContext // using System.Data.Entity gerektirir.
    {
        // Hangi nesneyi veritabanında neye bağlayacağını belirtiriz.

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
