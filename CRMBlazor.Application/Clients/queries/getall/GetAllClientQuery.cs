﻿using AutoMapper;
using CRMBlazor.Application.Clients.Commands.Add;
using CRMBlazor.Application.Common.Interfaces.Persistance;
using CRMBlazor.Domain.Clients;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Clients.Queries.GetAll
{
    public class GetAllClientQuery : IRequestHandler<AddClientCommand, ErrorOr<Guid>>
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public GetAllClientQuery(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ErrorOr<Guid>> Handle(AddClientCommand request, CancellationToken cancellationToken)
        {
            Client model = _mapper.Map<Client>(request);
            await _clientRepository.Add(model);
            return request.Id;
        }

    }
}
