
using Repository.Models;
using Repository.Repo;

namespace ClubMemberShip.Repo.UnitOfWork;

public class UnitOfWork 
{
    private readonly MyStoreContext _context = new();
    private CategoryRepo? categoryRepo;
    private ProductRepo? productRepo;
    private AccountMemberRepo? accountMemberRepo;


    public CategoryRepo CategoryRepo => categoryRepo ??= new CategoryRepo(_context);
    public ProductRepo ProductRepo => productRepo ??= new ProductRepo(_context);
    public AccountMemberRepo AccountMemberRepo => accountMemberRepo ??= new AccountMemberRepo(_context);


    public int SaveChange()
    {
        return _context.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}