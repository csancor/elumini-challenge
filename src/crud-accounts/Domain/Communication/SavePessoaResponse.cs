using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Communication
{
    public class SavePessoaResponse : BaseResponse
    {
        public Pessoa Pessoa { get; private set; }

        private SavePessoaResponse(bool success, string message, Pessoa pessoa) : base(success, message)
        {
            Pessoa = pessoa;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="pessoa">Saved category.</param>
        /// <returns>Response.</returns>
        public SavePessoaResponse(Pessoa pessoa) : this(true, string.Empty, pessoa)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SavePessoaResponse(string message) : this(false, message, null)
        { }
    }
}
