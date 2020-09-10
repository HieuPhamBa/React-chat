using System;
using System.ComponentModel.DataAnnotations;

namespace ReactChat.Web.Models.Requests
{
    public class LoginEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
