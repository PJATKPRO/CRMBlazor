using CRMBlazor.Infrastructure.Contexts.CRMBlazorDb;
using System.ComponentModel.DataAnnotations;

namespace CRMBlazor.Infrastructure.Contexts.CRMBlazorDb
{
    public class Client
    {

        public Client()
        {
            Flows = new HashSet<Flow>();
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
        public string Email { get; set; }

        [MaxLength(50, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string? PeselOrNip { get; set; }

        [MaxLength(500, ErrorMessage = "Pole {0} nie może mieć więcej niż {1} znaków.")]
        public string? Description { get; set; }

        public Address? Address { get; set; } = null!;
        public Address? InvestitionAddress { get; set; } = null!;
        public ICollection<Flow> Flows { get; set; } = null!;

    }
}
