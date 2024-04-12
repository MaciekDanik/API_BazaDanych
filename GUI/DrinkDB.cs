using API_BazaDanych;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
        public class DrinkDB : DbContext
        {
            public DbSet<Drink> Drinks { get; set; }
            public DrinkDB()
            {
                Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlite(@"Data Source=DrinksV3.db");
            }
        }
}
