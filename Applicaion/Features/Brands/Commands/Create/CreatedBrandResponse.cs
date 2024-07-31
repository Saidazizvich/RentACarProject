using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaion.Features.Brands.Commands.Create;

public class CreatedBrandResponse
{
    public Guid Id { get; set; } // burda esa biz sonuc gonderiyoruz dikkkat id ve name response 
    public string Name { get; set; }

    public DateTime CreateDate { get; set; }
    public DateTime UpdateDate { get; set; }
}

