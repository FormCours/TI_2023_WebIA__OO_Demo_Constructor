using Demo_Ctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ctor.Models
{
    public class PersonV1 : IPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthdate { get; set; }


        public PersonV1(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname.ToUpper();
            this.Birthdate = null;
        }

        public PersonV1(string firstname, string lastname, DateTime birthdate)
            : this(firstname, lastname)
        {
            this.Birthdate = birthdate;
        }
    }
}
