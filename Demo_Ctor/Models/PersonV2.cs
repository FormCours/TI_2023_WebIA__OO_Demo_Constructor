using Demo_Ctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ctor.Models
{
    public class PersonV2 : IPerson
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthdate { get; set; }


        public PersonV2(string firstname, string lastname)
            : this(firstname, lastname, null)
        { }

        public PersonV2(string firstname, string lastname, DateTime? birthdate)
        {
            this.Firstname = firstname;
            this.Lastname = lastname.ToUpper();
            this.Birthdate = birthdate;
        }
    }
}
