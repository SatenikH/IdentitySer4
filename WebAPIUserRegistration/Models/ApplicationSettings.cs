using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIUserRegistration.Models
{
    public class ApplicationSettings
    {
        public string JWTSecret { get; set; }
        public string ClientURL { get; set; }
    }
}
