using System.ComponentModel.DataAnnotations;

namespace FirstMafiaWar.Models.Requests
{
    public class RegisterRequest
    {
        [Required] public string Username { get; set; }

        [Required] [EmailAddress] public string EmailAddress { get; set; }

        [Required] public string Password { get; set; }
    }
}
