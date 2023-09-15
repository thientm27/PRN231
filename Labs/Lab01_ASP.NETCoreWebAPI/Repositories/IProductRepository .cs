using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Products p);
        Products GetProductsById(int id);
        void DeleteProduct(Products p);
        void UpdateProduct(Products p);
        List<Category> GetCategories();
        List<Products> GetProducts();
    }
}
