﻿using GestaoProdutos.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Interfaces.Products.Service
{
    public interface IProductService : IBaseService<Product, Guid>
    {
    }
}
