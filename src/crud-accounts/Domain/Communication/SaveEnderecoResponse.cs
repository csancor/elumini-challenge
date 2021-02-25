using crud_accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Domain.Communication
{
    public class SaveEnderecoResponse : BaseResponse
    {
        public Endereco Endereco { get; private set; }

        private SaveEnderecoResponse(bool success, string message, Endereco endereco) : base(success, message)
        {
            Endereco = endereco;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="endereco">Saved category.</param>
        /// <returns>Response.</returns>
        public SaveEnderecoResponse(Endereco endereco) : this(true, string.Empty, endereco)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveEnderecoResponse(string message) : this(false, message, null)
        { }
    }
}

