using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CRMBlazor.Shared.Data.CRMBlazorDb.Models
{
    [Owned]
    public sealed partial class Address
    {
        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string Street { get; set; }

        [MaxLength(6, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        [MinLength(6, ErrorMessage = "Pole {0} nie może mieć mniej niż {1} znaków.")]
        public string PostCode { get; set; }

        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string City { get; set; }
    }
}
