using CRMBlazor.Application.Common.Commands;
using CRMBlazor.Domain.Base.Common.ValueObjects;
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
    public record AddClientCommand(Guid Id, string Name, string Surname, string Email, string? PeselOrNip, string? Description, AddressCommand? Address, AddressCommand? InvestitionAddress) : IRequest<ErrorOr<Guid>>;

}
