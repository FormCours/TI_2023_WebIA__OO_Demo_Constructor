using Demo_Ctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ctor.Models
{
    public class Teacher : PersonV1, ITeacher
    {
        public string Domain { get; set; }

        public Teacher(string firstname, string lastname, DateTime birthdate, string domain)
            : base(firstname, lastname, birthdate)
        {
            this.Domain = domain;
        }

        public void Teach()
        {
            Console.WriteLine($"{Firstname} donne cours !");
        }
    }
}
