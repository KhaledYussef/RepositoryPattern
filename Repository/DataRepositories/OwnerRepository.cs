using Entities;
using Entities.Models;
using Interfaces.DataInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataRepositories
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext _repositoryContext) : base(_repositoryContext)
        {
        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return GetAll().ToList();
        }

        public Owner GetOwnerById(int id)
        {
            return FindByCondition(x => x.OwnerId == id).Include(a=>a.Accounts.Select(b=>new {b.AccountId,b.AccountType })).FirstOrDefault();
        }
    }
}
