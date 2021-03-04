using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        //kayıt olmak isteyen biri için kodlarımız
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
