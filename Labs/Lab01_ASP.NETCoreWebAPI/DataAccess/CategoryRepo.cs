using BusinessObjects;
using ClubMemberShip.Repo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryRepo : GenericRepo<Category>
    {
        public CategoryRepo(MyDbContext context) : base(context)
        {
        }
    }
}
