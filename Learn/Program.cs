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
            Room rooms = new Room("Твоя комната", CreatePersonThread.returnPerson());
            rooms.AddInSideObject(BoxRoom.sides.center, new GeneralObjects("Стол", "На столе лежат канцелярские вещи. Там лежит яблоко.\n\rЗапахло скукой...", true),
                new GeneralObjects("Кресло качели", "Вы любите засыпать на них"));
            rooms.AddInSideObject(BoxRoom.sides.south, new GeneralObjects("Окно", "Просто окно"));
            rooms.Go(BoxRoom.sides.center);
            Console.ReadLine();

        }
    }
}
