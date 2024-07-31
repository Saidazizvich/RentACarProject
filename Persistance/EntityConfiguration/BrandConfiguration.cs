using Domain.Entitties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityConfiguration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>   
    {



        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands").HasKey();  
            builder.Property(x => x.Id).HasColumnName("Id");
            //builder.Property(z=>z.Name).IsRequired().HasMaxLength(40); // 1 ci yontem
            //builder.Property(z => z.CreatedDate).IsRequired(); 
            //builder.Property(z => z.DeleteDate).IsRequired(); 
            //builder.Property(z => z.UpdateDate).HasColumnName()
            // builder.Property()


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(40);
            builder.Property(z => z.CreatedDate).IsRequired();             // 2 ci yontem
            builder.Property(z => z.DeleteDate).IsRequired();
            builder.Property(z => z.UpdateDate).IsRequired();
                        // ! yoksa salis                   // yoksa calisma
            builder.HasQueryFilter(x => !x.DeleteDate.HasValue);
        }
    }
}
