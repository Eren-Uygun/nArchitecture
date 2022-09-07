using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, BaseDbContext>, IBrandRepository
    {
        //BrandRepository adı c#'da sürekli entity framework kullanıldığından esktra isimlendirme yapmamak için konuldu. Yoksa EfBrandRepository Base diyerek ef için olduğunuda belirtebiliriz.
        public BrandRepository(BaseDbContext context) : base(context)
        {
        }
    }
}


//Unit test yazarken dataAccess'e gitmememiz gerekiyor.