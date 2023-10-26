using Demo_Ctor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ctor.Models
{
    public class Student : PersonV1, IStudent
    {
        public string? Hobby { get; set; }

        private void Init()
        {
            this.Hobby = null;
        }
        public Student(string firstname, string lastname)
            : base (firstname, lastname)
        {
            Init();
        }
        public Student(string firstname, string lastname, string hobby)
            : base(firstname, lastname)
        {
            Init();
            this.Hobby = hobby;
        }
        public Student(string firstname, string lastname, DateTime birthdate)
            : base(firstname, lastname, birthdate)
        {
            Init();
        }
        public Student(string firstname, string lastname, DateTime birthdate, string hobby)
            : base(firstname, lastname, birthdate)
        {
            Init();
            this.Hobby = hobby;
        }




        public void Study()
        {
            Console.WriteLine($"{Firstname} etudie");
        }
        public void Play()
        {
            Console.WriteLine($"{Firstname} joue au jeu videal");
        }
    }
}
