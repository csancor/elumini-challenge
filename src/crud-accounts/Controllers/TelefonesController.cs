using AutoMapper;
using crud_accounts.Models;
using crudAccounts.Domain.Models;
using crudAccounts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudAccounts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelefonesController : ControllerBase
    {
        private readonly ITelefoneRepository _telefoneRepository;
        private readonly IMapper _mapper;

        public TelefonesController(ITelefoneRepository telefoneRepository, IMapper mapper)
        {
            _telefoneRepository = telefoneRepository;
            _mapper = mapper;
        }

        [HttpGet()]
        public IActionResult GetTelefones()
        {
            var TelefonesFromRepo = _telefoneRepository.GetTelefones();
            return Ok(_mapper.Map<IEnumerable<TelefoneDto>>(TelefonesFromRepo));
        }

        [HttpGet("{telefoneId}")]
        public IActionResult GetAuthor(Guid telefoneId)
        {
            var telefoneFromRepo = _telefoneRepository.GetTelefoneById(telefoneId);

            if (telefoneFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TelefoneDto>(telefoneFromRepo));
        }

        [HttpPost]
        public ActionResult<TelefoneDto> CreateTelefone(TelefoneForCreationDto telefone)
        {
            var telefoneEntity = _mapper.Map<Telefone>(telefone);
            _telefoneRepository.AddTelefone(telefoneEntity);
            _telefoneRepository.Save();

            var telefoneToReturn = _mapper.Map<TelefoneDto>(telefoneEntity);
            return CreatedAtRoute("GetTelefone",
                new { telefoneId = telefoneToReturn.Id },
                telefoneToReturn);
        }
    }
}
