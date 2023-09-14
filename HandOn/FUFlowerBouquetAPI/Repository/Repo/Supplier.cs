using DataAccessObject.DAOs;
using Repository.Models;


namespace Repository.Repo
{
    public class Supplier : GenericRepo<Supplier>
    {
        public Supplier(FUFlowerBouquetManagementV4Context context) : base(context)
        {
        }
    }
}
