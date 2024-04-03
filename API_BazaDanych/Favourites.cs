using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_BazaDanych
{
    internal class Favourites : DbContext
    {
        public DbSet<Drink> FavDrinks { get; set; }
        public Favourites()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=Univ.db");
        }
    }
}
