using IdetityAjax.BOs;

namespace IdetityAjax.Repositories
{
    public interface IProductRepository
    {
        void SaveProduct(Product product);

        Product GetProductById(int id);

        void DeleteProduct(Product product);

        List<Category> GetCategories();
        List<Product> GetProducts();
        void UpdateProduct(Product product);
    }
}
