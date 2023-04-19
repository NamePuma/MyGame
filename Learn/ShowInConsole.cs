using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class ShowInConsole
    {
       protected string Name { get; set; }

        protected Enum currentSide { get; set; }
       protected void Print(IPerson person) 
        {
            Console.WriteLine(Messeds.CORRENTROOM + Name);
            Console.WriteLine(Messeds.BORDER);
            Console.WriteLine(currentSide);
            Console.WriteLine(Messeds.BORDER);
            Console.WriteLine(Messeds.CORRENTPERSON + person.Name);
            Console.WriteLine();
            Console.WriteLine(Messeds.OBJECTROOM);
        }
    }
}
