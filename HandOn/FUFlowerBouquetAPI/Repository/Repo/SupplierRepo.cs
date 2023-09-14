using DataAccessObject.DAOs;
using Repository.Models;


namespace Repository.Repo
{
    public class SupplierRepo : GenericRepo<Supplier>
    {
        public SupplierRepo(FUFlowerBouquetManagementV4Context context) : base(context)
        {
        }
    }
}
