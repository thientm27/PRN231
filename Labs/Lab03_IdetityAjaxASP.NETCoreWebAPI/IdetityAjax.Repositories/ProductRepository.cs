using IdetityAjax.BOs;
using IdetityAjax.DataAccess;

namespace IdetityAjax.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public void SaveProduct(Product product)
        {
            ProductDAO.SaveProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.UpdateProduct(product);
        }

        public Product GetProductById(int id)
        {
            return ProductDAO.FindProductById(id);
        }

        public void DeleteProduct(Product product)
        {
            ProductDAO.DeleteProduct(product);
        }

        public List<Category> GetCategories()
        {
            return CategoryDAO.GetCategories();
        }
        public List<Product> GetProducts()
        {
            return ProductDAO.GetProducts();
        }
    }
}
