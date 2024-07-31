using Domain.Entitties;
using Persistance.DBContext;
using Core.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Applicaion.Service.Repositories;


namespace Persistance.Repsitories
{   // burda eklenmedi ben sadece class adi olarak geranation ekledim yani burda bu katman Reference etmasi lazim  Core.Persistance.Repositories;

    public class BrandRepository:EfRepositoryBase<Brand,Guid,BaseDbContext>, IBrandRepository
    {
        public BrandRepository()
        {
            
        }
    }
}
