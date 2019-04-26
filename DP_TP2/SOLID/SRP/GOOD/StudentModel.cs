using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRP
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Guid StudentId { get; set; }
    }
}