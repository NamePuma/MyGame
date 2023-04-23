using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using WMPLib;

namespace Learn
{

    public class Program
    {

        static void Main(string[] args)
        {
            BasicThread basicThread = new BasicThread();
            Room myRoom = new Room("Моя комната", CreatePersonThread.returnPerson());
            myRoom.AddInSideObject(BoxRoom.sides.north,
                new GameObjectWithCount("Окно", "За окном яркий день"),
                new GameObjectWithCount("Картина", "Криво нарисованая картина.\r\nКажется она ваша"),
                new GameObjectWithCount("Стол", "На столе лежать разные скучну вещи",
                delegate
                {
     
                    Whither.DontClear("На столе лежит яблоко.\r\nВзять его?");
                    string answer = Whither.Swith("Да", "Нет"); if (answer == "Да")
                        { CreatePersonThread.returnPerson().GiveInInventory(new MicroObject("Яблоко", "Вкусное заливное")); }
                    else { Console.WriteLine("Вы не любите яблоки"); }
                }, delegate { Console.WriteLine("На столе лежать вещи"); }),
                new GameObjectWithCount("Дверь", "Просто дверь. \r\nМожно выйти(Восток)")
                ) ;
            myRoom.Go(BoxRoom.sides.north);

        }
    }
}
