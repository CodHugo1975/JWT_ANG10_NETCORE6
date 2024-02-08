using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class UserLogin
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string Shift { get; set; }
        public string Role { get; set; }
        public string SystemUser { get; set; }
        public string Password { get; set; }
    }
}
