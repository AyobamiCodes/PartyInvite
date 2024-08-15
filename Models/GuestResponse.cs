using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage = "Please enter your firstname")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your lastname")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your card number")]
        public string? CardNumber { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
