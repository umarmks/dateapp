using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
   public class UserForRegisterDto
   {
      [Required]
      public string Username { get; set; }

      [Required]
      [StringLength(8, MinimumLength = 4, ErrorMessage = "Required length is > 8 chars")]
      public string Password { get; set; }

   }
}