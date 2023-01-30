using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBlazor.Application.Common.Commands
{
    public record AddressCommand(string Street, string PostCode, string City);

}
