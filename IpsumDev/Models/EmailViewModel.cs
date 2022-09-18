using System.ComponentModel.DataAnnotations;

namespace IpsumDev.Models
{
    public class EmailViewModel
    {
        [EmailAddress]
        [UIHint("EmailAddress")]
        public string? Email { get; set; }
    }
}
