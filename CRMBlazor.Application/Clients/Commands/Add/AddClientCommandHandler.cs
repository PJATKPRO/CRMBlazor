using AutoMapper;
using CRMBlazor.Application.Common.Interfaces.Persistance;
using CRMBlazor.Domain.Clients;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Clients.Commands.Add
{
    public class AddClientCommandHandler : IRequestHandler<AddClientCommand, ErrorOr<Guid>>
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public AddClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ErrorOr<Guid>> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            Client model = _mapper.Map<Client>(request);
            await _clientRepository.Add(model);
            return request.Id;
        }
    }
}
