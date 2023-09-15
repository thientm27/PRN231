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
            return productRepo.Get();
        }

        public Products GetProductsById(int id)
        {
            return productRepo.GetByID(id);
        }

        public void SaveProduct(Products p)
        {
             productRepo.Create(p);
        }

        public void UpdateProduct(Products p)
        {
            productRepo.Update(p);
        }
    }
}