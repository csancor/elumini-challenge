using AutoMapper;
using crud_accounts.Models;
using crudAccounts.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Profiles
{
    public class TelefonesProfile : Profile
    {
        public TelefonesProfile()
        {
            CreateMap<Telefone, TelefoneDto>();

            CreateMap<TelefoneForCreationDto, Telefone>();
        }    
    }
}
                

