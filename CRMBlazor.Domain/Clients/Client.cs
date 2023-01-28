using CRMBlazor.Domain.Base.Common.Models;
using CRMBlazor.Domain.Base.Common.ValueObjects;
using CRMBlazor.Domain.Clients.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMBlazor.Domain.Clients
{
    public sealed class Client : AggregateRoot<ClientId>
    {


        public static Client Create(ClientId clientId, string name, string surname, string email, string? peselOrNip, string? description, Address? address, Address? investitionAddress)
        {
            return new Client(clientId, name, surname, email, peselOrNip, description, address, investitionAddress);
        }

        private Client(ClientId id, string name, string surname, string email, string? peselOrNip, string? description, Address? address, Address? investitionAddress) : base(id)
        {
            Name = name;
            Surname = surname;
            Email = email;
            PeselOrNip = peselOrNip;
            Description = description;
            Address = address;
            InvestitionAddress = investitionAddress;
        }


        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }

        public string? PeselOrNip { get; set; }

        public string? Description { get; set; }

        public Address? Address { get; set; } = null!;
        public Address? InvestitionAddress { get; set; } = null!;
        private Client() { }


    }
}
