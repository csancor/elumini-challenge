using AutoMapper;
using crud_accounts.Models;
using crudAccounts.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Pessoa, PessoaResource>();
            
            CreateMap<Endereco, EnderecoResource>();
            
            
        }
    }
}
