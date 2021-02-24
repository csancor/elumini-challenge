using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Repositories.Persistence
{
    public class BaseRepository
    {
        protected readonly ApiDbContext _context;

        public BaseRepository(ApiDbContext context)
        {
            _context = context;
        }
    }
}
