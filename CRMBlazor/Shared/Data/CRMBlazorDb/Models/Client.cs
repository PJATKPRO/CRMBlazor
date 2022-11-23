using System.ComponentModel.DataAnnotations;

namespace CRMBlazor.Shared.Data.CRMBlazorDb.Models
{
    public partial class Client
    {

        public Client()
        {
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pole {0} jest wymagane.")]
        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string Surname { get; set; }

        [MaxLength(128, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        [EmailAddress]
        public string Email { get; set; } = "default@mail.com";

        [MaxLength(50, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string? PeselOrNip { get; set; }

        [MaxLength(500, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string? Description { get; set; }

        public virtual Address? Address { get; set; } = null!;
        public virtual Address? InvestitionAddress { get; set; } = null!;

    }
}
