using System.ComponentModel.DataAnnotations;

namespace CRMBlazor.Application.Common.Models
{

    public partial class Address
    {
        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string Street { get; set; } = string.Empty;

        [MaxLength(6, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        [MinLength(6, ErrorMessage = "Pole {0} nie może mieć mniej niż {1} znaków.")]
        public string PostCode { get; set; } = string.Empty;

        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string City { get; set; } = string.Empty;
    }
}
