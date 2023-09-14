using ClubMemberShip.Repo.UnitOfWork;
using ClubMemberShip.Service.Service;
using DataAccessObject.Utils;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategotyService : GenericService<Category>, ICategoryService
    {
        public CategotyService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override void Add(Category newEntity)
        {

            var maxId = UnitOfWork.CategoryRepo.Get().Max(o => o.CategoryId);
            newEntity.CategoryId = maxId + 1;

            UnitOfWork.CategoryRepo.Create(newEntity);
            UnitOfWork.SaveChange();


            UnitOfWork.CategoryRepo.Create(newEntity);
            UnitOfWork.SaveChange();
        }

        public override void Delete(object idToDelete)
        {
            UnitOfWork.CategoryRepo.DeleteById(idToDelete);
            UnitOfWork.SaveChange();
        }

        public override List<Category>? Get()
        {
            return UnitOfWork.CategoryRepo.Get();
        }

        public override Category? GetById(object? id)
        {
            return UnitOfWork.CategoryRepo.GetById(id);
        }

        public override Pagination<Category> GetPagination(int pageIndex, int pageSize)
        {
            var listEntities = Get();
            return UnitOfWork.CategoryRepo.ToPagination(listEntities, pageIndex, pageSize);

        }

        public override void Update(Category newEntity)
        {
            UnitOfWork.CategoryRepo.Update(newEntity);
            UnitOfWork.SaveChange();
        }
    }
}
