using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ctor.Interfaces
{
    public interface IPerson
    {
        string Firstname { get; }
        string Lastname { get; }
        DateTime? Birthdate { get; }
    }
}
