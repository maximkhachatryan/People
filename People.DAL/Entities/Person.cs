using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.DAL.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CrDate { get; set; }
    }
}
