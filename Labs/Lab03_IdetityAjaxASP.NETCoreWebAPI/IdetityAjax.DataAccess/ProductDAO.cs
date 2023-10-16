using IdetityAjax.BOs;
using Microsoft.EntityFrameworkCore;

namespace IdetityAjax.DataAccess
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();

            try
            {
                using (var context = new MyDbContext())
                {
                    listProducts = context.Products.Include(p => p.Category).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }

        public static Product FindProductById(int id)
        {
            Product product = new Product();

            try
            {
                using (var context = new MyDbContext())
                {
                    product = context.Products.SingleOrDefault(p => p.ProductId.Equals(id));
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return product;
        }

        public static void SaveProduct(Product product)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteProduct(Product product)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var p = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                    if (p != null)
                    {
                        context.Products.Remove(p);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}