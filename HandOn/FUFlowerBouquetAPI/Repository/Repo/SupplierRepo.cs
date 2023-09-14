using DataAccessObject.DAOs;
using Repository.Models;


namespace Repository.Repo
{
    public class SupplierRepo : GenericRepo<Supplier>
    {
        public Supplier(FUFlowerBouquetManagementV4Context context) : base(context)
        {
        }
    }
}
