using DataAccessObject.DAOs;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class AccountMemberRepo : GenericRepo<AccountMember>
    {
        public AccountMemberRepo(MyStoreContext context) : base(context)
        {
        }

        public override AccountMember? GetById(object? id)
        {
            throw new NotImplementedException();
        }
    }
}
