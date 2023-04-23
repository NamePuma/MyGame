using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class PassIN : GameObjec
    {
        public delegate void Side(BoxRoom.sides side);

        public PassIN()
        {
            Name = "Перейти в...";
            Description = "Описание";
        }

       
        public void Action(Side side, Side sideAbroad, BoxRoom.sides sides)
        {
            Whither.DontClear(Messeds.WHEREGO, Messeds.BORDER);
            
            if (sides == BoxRoom.sides.south)
            { 
                var strSide = Whither.Swith(Messeds.NORTH, Messeds.CENTER);
                switch (strSide)
                {
                    case Messeds.NORTH:
                        sideAbroad(BoxRoom.sides.north);
                        break;
                    case Messeds.CENTER:
                        side(BoxRoom.sides.center);
                        break;
                }
            }
            if (sides == BoxRoom.sides.center)
            {
                var strSide = Whither.Swith(Messeds.NORTH, Messeds.WEST, Messeds.EAST, Messeds.SOUTH);
                switch (strSide)
                {
                    case Messeds.NORTH:
                        side(BoxRoom.sides.north);
                        break;
                    case Messeds.WEST:
                        side(BoxRoom.sides.west);
                        break;
                    case Messeds.EAST:
                        side(BoxRoom.sides.east);
                        break;
                    case Messeds.SOUTH:
                        side(BoxRoom.sides.south);
                        break;
                }
            }
            if (sides == BoxRoom.sides.north)
            {
                var strSide = Whither.Swith(Messeds.SOUTH, Messeds.CENTER);
                switch (strSide)
                {
                    case Messeds.SOUTH:
                        sideAbroad(BoxRoom.sides.south);
                        break;
                    case Messeds.CENTER:
                        side(BoxRoom.sides.center);
                        break;
                }
            }
            if (sides == BoxRoom.sides.east)
            {
                var strSide = Whither.Swith(Messeds.WEST, Messeds.CENTER);
                switch (strSide)
                {
                    case Messeds.WEST:
                        sideAbroad(BoxRoom.sides.west);
                        break;
                    case Messeds.CENTER:
                        side(BoxRoom.sides.center);
                        break;
                }
            }
            if (sides == BoxRoom.sides.west)
            {
                var strSide = Whither.Swith(Messeds.EAST, Messeds.CENTER);
                switch (strSide)
                {
                    case Messeds.EAST:
                        sideAbroad(BoxRoom.sides.east);
                        break;
                    case Messeds.CENTER:
                        side(BoxRoom.sides.center);
                        break;
                }
            }
        }

        public override void Reaction(CreatePerson person)
        {
            return;
        }
    }
}
