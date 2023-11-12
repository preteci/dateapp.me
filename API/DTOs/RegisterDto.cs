using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    // json will bind to properties even if they are lowercase here so Username => username
    // api controller atribute is fired before the function isnide of it so the [Requrired] will only work if we dont use
    // the thing called [FromBody] inside function

    public class RegisterDto
    {
        [Required]
        public string Username { get; set;}
        [Required]
        public string Password {get; set;}
    }
}