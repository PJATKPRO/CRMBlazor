using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Clients;
using CRMBlazor.Domain.Clients.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Interfaces.Persistance
{
    internal interface IClientRepository
    {
        Task<Client> Create(ClientId clientId, string name, string surname, string email, string? peselOrNip, string? description, Address? address, Address? investitionAddress);
        Task<IReadOnlyList<Client>> GetAll();
        Task<Client> Get(ClientId id);
        Task Update(Client client);
        Task Delete(ClientId id);
        Task Add(Client client);

    }
}
