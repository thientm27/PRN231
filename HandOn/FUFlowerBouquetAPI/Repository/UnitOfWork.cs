
using Repository.Models;
using Repository.Repo;

namespace ClubMemberShip.Repo.UnitOfWork;

public class UnitOfWork 
{
    private readonly FUFlowerBouquetManagementV4Context _context = new();
    private CatogoryRepo? categoryRepo;
    private CustomerRepo? customerRepo;
    private OrderDetailRepo? orderDetailRepo;
    private OrderRepo? orderRepo;
    private SupplierRepo? supplierRepo;

    public CatogoryRepo CatogoryRepo => categoryRepo ??= new CatogoryRepo(_context);
    public CustomerRepo CustomerRepo => customerRepo ??= new CustomerRepo(_context);
    public OrderDetailRepo OrderDetailRepo => orderDetailRepo ??= new OrderDetailRepo(_context);
    public OrderRepo OrderRepo => orderRepo ??= new OrderRepo(_context);
    public SupplierRepo SupplierRepo => supplierRepo ??= new SupplierRepo(_context);


    public int SaveChange()
    {
        return _context.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}