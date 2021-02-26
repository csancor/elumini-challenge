using crud_accounts.Models;
using crudAccounts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Repositories.Persistence
{
    public class TelefoneRepository : ITelefoneRepository, IDisposable
    {
        private readonly ApiDbContext _context;

        public TelefoneRepository(ApiDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Telefone> GetTelefones()
        {
            return _context.Telefones.ToList<Telefone>();
        }


        Telefone ITelefoneRepository.GetTelefoneById(Guid Id)
        {
            if (Id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(Id));
            }

            return _context.Telefones.FirstOrDefault(a => a.Id == Id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public void AddTelefone(Telefone telefone)
        {
            if (telefone == null)
            {
                throw new ArgumentNullException(nameof(telefone));
            }

            // the repository fills the id (instead of using identity columns)
            telefone.Id = Guid.NewGuid();

            foreach (var telefoneData in telefone.Telefones)
            {
                telefoneData.Id = Guid.NewGuid();
            }

            _context.Telefones.Add(telefone);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
