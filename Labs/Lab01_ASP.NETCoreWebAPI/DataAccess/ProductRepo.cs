using BusinessObjects;
using ClubMemberShip.Repo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductRepo : GenericRepo<Products>
    {
        public ProductRepo(MyDbContext context) : base(context)
        {
        }
    }
}
