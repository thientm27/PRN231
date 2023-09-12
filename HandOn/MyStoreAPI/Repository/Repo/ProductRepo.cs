using DataAccessObject.DAOs;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class ProductRepo : GenericRepo<Product>
    {
        public ProductRepo(MyStoreContext context) : base(context)
        {
        }

        public override Product? GetById(object? id)
        {
            throw new NotImplementedException();
        }
    }
}
