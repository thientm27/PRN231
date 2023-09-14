using DataAccessObject.DAOs;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    internal class OrderRepo : GenericRepo<OrderDetail>
    {
        public OrderRepo(FUFlowerBouquetManagementV4Context context) : base(context)
        {
        }
    }
}
