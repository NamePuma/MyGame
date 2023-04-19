using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class GeneralObjects : GameObjec
    {
        public GeneralObjects(string name, string description, bool movie = false) 
        {
            Name = name;
            Description = description;
            Movie = movie;
        }
        public override void Action(CreatePerson person)
        {
            Whither.DontClear(description);
            Whither.Swith("Yes", "No");
        }

        public override void Reaction(CreatePerson person)
        {
            touch = true;
            if (Movie)
            {
                Action(person);
                return;
            }
            Console.WriteLine(description);
            
        }
    }
}
