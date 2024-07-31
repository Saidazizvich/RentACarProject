using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Quries.GetById
{
    public class GetByIdListResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
