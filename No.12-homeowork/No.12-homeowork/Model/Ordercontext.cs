using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace No._12_homeowork.Model
{
    
        public class OrderContext : DbContext
        {
            public OrderContext(DbContextOptions<OrderContext> options)
                : base(options)
            {
                this.Database.EnsureCreated(); //自动建库建表
            }

            public DbSet<Order> orders { get; set; }
            public DbSet<Orderitem> orderitems { get; set; }
        }
    
}
