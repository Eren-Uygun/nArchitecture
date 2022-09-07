using Core.Persistence.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Repositories
{
    public interface IBrandRepository:IAsyncRepository<Brand>,IRepository<Brand>
    {
        //Brand için olan özel operasyonlar yazılabilir.Ancak sadece brand için olmalı
    }
}
