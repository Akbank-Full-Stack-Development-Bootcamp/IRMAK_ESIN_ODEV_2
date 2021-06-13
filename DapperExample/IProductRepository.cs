using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{

    public Interface IProductRepository
    {

        IEnumerable<Product> GetProduct();

        bool Insert(IProductRepository product);

        bool Update(IProductRepository product);

        bool Delete(String productId);

    }
}

