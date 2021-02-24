using crud_accounts.Models;
using crudAccounts.Domain.Communication;
using crudAccounts.Domain.Repositories;
using crudAccounts.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PessoaService(IPessoaRepository pessoaRepository, IUnitOfWork unitOfWork)
        {
            _pessoaRepository = pessoaRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Pessoa>> ListAsync()
        {
            return await _pessoaRepository.ListAsync();
        }

        public async Task<SavePessoaResponse> SaveAsync(Pessoa pessoa)
        {
            try
            {
                await _pessoaRepository.AddAsync(pessoa);
                await _unitOfWork.CompleteAsync();

                return new SavePessoaResponse(pessoa);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new SavePessoaResponse($"Erro ao salvar as informações de usuário: {ex.Message}");
            }
        }
    }
}
