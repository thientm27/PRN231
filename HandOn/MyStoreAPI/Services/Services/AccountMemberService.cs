using ClubMemberShip.Repo.UnitOfWork;
using ClubMemberShip.Service.Service;
using DataAccessObject.Utils;
using Repository.Models;


namespace Services.Services
{
    public class AccountMemberService : GenericService<AccountMember>, IAccountMemberService
    {
        public AccountMemberService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override void Add(AccountMember newEntity)
        {

            var maxId = UnitOfWork.AccountMemberRepo.Get().Max(o => o.MemberId);
            newEntity.MemberId = maxId + 1;

            UnitOfWork.AccountMemberRepo.Create(newEntity);
            UnitOfWork.SaveChange();
        }

        public override void Delete(object idToDelete)
        {
            UnitOfWork.AccountMemberRepo.DeleteById(idToDelete);
            UnitOfWork.SaveChange();
        }

        public override List<AccountMember>? Get()
        {

            return UnitOfWork.AccountMemberRepo.Get();
        }

        public override AccountMember? GetById(object? id)
        {
            return UnitOfWork.AccountMemberRepo.GetById(id);
        }

        public override Pagination<AccountMember> GetPagination(int pageIndex, int pageSize)
        {
            var listEntities = Get();
            return UnitOfWork.AccountMemberRepo.ToPagination(listEntities, pageIndex, pageSize);
        }

        public override void Update(AccountMember newEntity)
        {
            UnitOfWork.AccountMemberRepo.Update(newEntity);
            UnitOfWork.SaveChange();
        }
    }
}
