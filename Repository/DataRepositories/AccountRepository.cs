using Entities;
using Entities.Models;
using Interfaces.DataInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataRepositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        private readonly RepositoryContext context;

        public AccountRepository(RepositoryContext _context) : base(_context)
        {
            this.context = _context;
        }
    }
}
