using API_BazaDanych;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
        internal class DrinkDB : DbContext
        {
            public DbSet<Drink> Drinks { get; set; }
            //public string DBpath { get; set; }
            public DrinkDB()
            {
                Database.EnsureCreated();
                //var folder = Environment.SpecialFolder.LocalApplicationData;
                //var path = Environment.GetFolderPath(folder);
                //DBpath = System.IO.Path.Join(path, "Database\\Drink.db");
            }
            protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
            //options.UseSqlite($"Data Source={DBpath}");
            options.UseSqlite(@"Data Source=Drinks.db");
        }
        }
}
