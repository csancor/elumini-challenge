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


        Telefone ITelefoneRepository.GetTelefoneById(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Telefones.FirstOrDefault(a => a.Id == id);
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

            foreach (var telefoneDb in telefone.Telefones)
            {
                telefoneDb.Id = Guid.NewGuid();
            }

            _context.Telefones.Add(telefone);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}
