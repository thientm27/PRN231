using BusinessObjects;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {

        ProductRepo productRepo = new(new MyDbContext());
        CategoryRepo categoryRepo = new(new MyDbContext());
        public void DeleteProduct(Products p)
        {
            productRepo.Delete(p);
}

        public List<Category> GetCategories()
        {
        return categoryRepo.Get();
        }

        public List<Products> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Products GetProductsById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveProduct(Products p)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Products p)
        {
            throw new NotImplementedException();
        }
    }
}
