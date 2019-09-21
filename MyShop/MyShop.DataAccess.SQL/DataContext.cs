﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyShop.Core.Models;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            :base("DefaultConnection")
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
