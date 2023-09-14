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
    internal class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override void Add(Product newEntity)
        {
            var maxId = UnitOfWork.ProductRepo.Get().Max(o => o.ProductId);
            newEntity.ProductId = maxId + 1;

            UnitOfWork.ProductRepo.Create(newEntity);
            UnitOfWork.SaveChange();
        }

        public override void Delete(object idToDelete)
        {
            UnitOfWork.ProductRepo.DeleteById(idToDelete);
            UnitOfWork.SaveChange();
        }

        public override List<Product>? Get()
        {

            return UnitOfWork.ProductRepo.Get();
        }

        public override Product? GetById(object? id)
        {

            return UnitOfWork.ProductRepo.GetById(id);
        }

        public override Pagination<Product> GetPagination(int pageIndex, int pageSize)
        {
            var listEntities = Get();
            return UnitOfWork.ProductRepo.ToPagination(listEntities, pageIndex, pageSize);
        }

        public override void Update(Product newEntity)
        {
            UnitOfWork.ProductRepo.Update(newEntity);
            UnitOfWork.SaveChange();
        }
    }
}
