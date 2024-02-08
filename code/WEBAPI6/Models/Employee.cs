using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
