using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    internal class MicroObject : GameObjec
    {
        public MicroObject(string name, string descr) 
        {
            Name = name;
            Description = descr;
        }
       

        public override void Reaction(CreatePerson person)
        {
            Console.WriteLine(Description);
        }
    }
}
