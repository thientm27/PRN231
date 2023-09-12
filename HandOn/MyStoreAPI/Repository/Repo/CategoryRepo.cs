using DataAccessObject.DAOs;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class CategoryRepo : GenericRepo<Category>
    {
        public CategoryRepo(MyStoreContext context) : base(context)
        {
        }

        public override Category? GetById(object? id)
        {
            throw new NotImplementedException();
        }
    }
}
