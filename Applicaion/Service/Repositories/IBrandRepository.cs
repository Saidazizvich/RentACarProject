using Domain.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistance.Repositories;


namespace Applicaion.Service.Repositories
{
    // Entity Interface islemini goruyor yani gerenation impelement ediyor dikkat bu katman su dir  Core.Persistance.Repositories;

    public interface IBrandRepository:IAsyncRepository<Brand>/*,IRepository<Brand>*/
    {
    }
}
