using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class Room : BoxRoom
    {
        public Room(string nameRoom, CreatePerson person) : base(nameRoom, person)
        {

        }

        protected override void selectedEast()
        {
            NonGo();
            Go(sides.west);
        }

        protected override void selectedNorth()
        {
            NonGo();
            Go(sides.south);
        }

        protected override void selectedSouth()
        {
            NonGo();
            Go(sides.north);
        }

        protected override void selectedWest()
        {
            
        }
        private void NonGo()
        {
            Console.WriteLine("Прохода нет, стена");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
