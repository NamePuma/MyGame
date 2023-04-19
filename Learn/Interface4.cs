using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
   public interface IPerson
    {
        string Name { get; }
        int Age { get; }
        int Balance { get; }

        Enum Sex{ get; }


    }
}
