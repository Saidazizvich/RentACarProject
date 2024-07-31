using Domain.Entitties;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.DBContext
{
    public class BaseDbContext : DbContext
    {
        // miras
        protected IConfiguration Configuration { get; set; } // ctor ichina yukliyoruz dikkat 

        public DbSet<Brand> Brands { get; set; }

        public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;  
            Database.EnsureCreated(); // birinci veri taban uyusturdan emin olmak icin kullaniyoruz dikkat
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // generation olarak tamomolaniyoruz dikkat 
        }
    }
}
