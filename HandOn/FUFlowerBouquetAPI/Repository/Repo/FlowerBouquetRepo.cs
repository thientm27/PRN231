using DataAccessObject.DAOs;
using Repository.Models;


namespace Repository.Repo
{
    public class FlowerBouquetRepo : GenericRepo<FlowerBouquet>
    {
        public FlowerBouquetRepo(FUFlowerBouquetManagementV4Context context) : base(context)
        {
        }
    }
}
