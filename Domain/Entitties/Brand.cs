using Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitties
{
    public class Brand:Entity<Guid>
    {   // inheritance common file
     
        public string Name { get; set; }

        public Brand()
        {
            
        }

        public Brand(int id,string name)
        {
             Id = id;
            Name = name;
        }


    }
}
