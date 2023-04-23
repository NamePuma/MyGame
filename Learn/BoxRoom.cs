using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public abstract class BoxRoom : ShowInConsole
    {
        private bool cansouth = false;
        public enum sides { center, south, north, east, west}
        protected CreatePerson person = null;
         
        protected List<GameObjec> centerObjects = new List<GameObjec>();
        protected List<GameObjec> southObjects = new List<GameObjec>();
        protected List<GameObjec> northObjects = new List<GameObjec>();
        protected List<GameObjec> eastObjects = new List<GameObjec>();
        protected List<GameObjec> westObjects = new List<GameObjec>();

        public BoxRoom(string nameRoom, CreatePerson person)
        {
           Name = nameRoom;
           this.person = person;
            centerObjects.Add(new PassIN());
            southObjects.Add(new PassIN());
            northObjects.Add(new PassIN());
            eastObjects.Add(new PassIN());
            westObjects.Add(new PassIN());
            

        }

        public void AddInSideObject( sides side, params GameObjec[] obj)
        {
            switch (side) 
            {
                case sides.center:
                    if (obj.Length == 0) { return; }
                    foreach (GameObjec objec in obj)
                    {
                        centerObjects.Add(objec);
                    }
                    break; 
                case sides.south:
                    if (obj.Length == 0) { return; }
                    foreach (GameObjec objec in obj)
                    {
                        southObjects.Add(objec);
                    }
                    break; 
                case sides.north:
                    if (obj.Length == 0) { return; }
                    foreach (GameObjec objec in obj)
                    {
                        northObjects.Add(objec);
                    }
                    break; 
                case sides.east:
                    if (obj.Length == 0) { return; }
                    foreach (GameObjec objec in obj)
                    {
                        eastObjects.Add(objec);
                    }
                    break; 
                case sides.west:
                    if (obj.Length == 0) { return; }
                    foreach (GameObjec objec in obj)
                    {
                        westObjects.Add(objec);
                    }
                    break;
            } 

        }
        public  void Go(sides side)
        {
            if (side == sides.center) 
            {
                currentSide = sides.center;
                center();
                
            }
            else if(side == sides.north) 
            {
                currentSide = sides.north;
                northSide();
                
            }
            else if(side == sides.east)
            {
                currentSide = sides.east;
                eastSide();
            }
            else if(side == sides.west)
            {
                currentSide = sides.west;
                westSide();
            }
            else if(side == sides.south)
            {
                currentSide = sides.south;
                southSide();    
            }

        }
        protected void goAbroad(sides side)
        {
            if (side == sides.south)
            {
                 selectedSouth();
            }
            else if (side == sides.west)
            {
                selectedWest();
            }
            else if (side == sides.east)
            {
               selectedEast();
            }
            else if( side == sides.north)
            {
                selectedNorth();
            }
            else if(side == sides.center)
            {
                center();
            }

        }

        protected void center()
        {
            Print(person);
            Whither.DontClearMethod(this.Print);
            var gameObj = Whither.Swith(centerObjects);
            if(gameObj is PassIN)
            {
                PassIN passIN = (PassIN)gameObj;
                passIN.Action(Go, goAbroad, sides.center);
                Whither.DontClearMethod(Print);
            }
            else
            {
                gameObj.Reaction(person);
                stringPrint();
                center();
            }
            

        }
        protected void southSide()
        {
            Print(person);
            Whither.DontClearMethod(this.Print);
            var gameObj = Whither.Swith(southObjects);
            if(gameObj is PassIN)
            {
                PassIN passIN = (PassIN)gameObj;
                passIN.Action(Go, goAbroad, sides.south);
                Whither.DontClearMethod(Print);
            }
            else
            {
                gameObj.Reaction(person);
                stringPrint();
                southSide();
            }
        }
        protected void northSide() 
        {
            Print(person);
            Whither.DontClearMethod(this.Print);
            var gameObj = Whither.Swith(northObjects);
            if(gameObj is PassIN) 
            {
                PassIN passIN = (PassIN)gameObj;
                passIN.Action(Go, goAbroad, sides.north);
                Whither.DontClearMethod(Print);
            }
            else
            {
                gameObj.Reaction(person);
                stringPrint();
                northSide();
            }
        }
        protected void eastSide() 
        {
            Whither.DontClearMethod(this.Print);
            Print(person);
            var gameObj = Whither.Swith(eastObjects);
            if(gameObj is PassIN) 
            {
                PassIN passIN = (PassIN)gameObj;
                passIN.Action(Go, goAbroad, sides.east);
                Whither.DontClearMethod(Print);
            }
            else
            {
                gameObj.Reaction(person);
                stringPrint();
                eastSide();
            }
        }
        protected void westSide() 
        {
            Print(person);
            Whither.DontClearMethod(this.Print);
            var gameObj = Whither.Swith(westObjects);
            if(gameObj is PassIN)
            {
                PassIN passIN = (PassIN)gameObj;
                passIN.Action(Go, goAbroad, sides.west);
                Whither.DontClearMethod(Print);
            }
            else
            {
                gameObj.Reaction(person);
                stringPrint();
                westSide();
            }
        }
        protected void stringPrint()
        {
            Console.WriteLine(Messeds.BORDER);
            Console.WriteLine(Messeds.GOAGAIN);
            Console.ReadKey(true);
            Console.Clear();
        }
        protected virtual  void selectedSouth()
        {
            NonGo();
            Go(sides.north);
        }
        protected virtual void selectedNorth()
        {
            NonGo();
            Go(sides.south);
        }
        protected virtual void selectedEast()
        {
            NonGo();
            Go(sides.west);
        }
        protected  virtual void selectedWest()
        {
            NonGo();
            Go(sides.east);
        }

        protected virtual void NonGo()
        {
            Console.WriteLine("Прохода нет");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
