using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class Whither
    {
        public delegate void Delegate(IPerson person);
        private static List<string> dontClear = new List<string>();

        private static Delegate dontClearMethod;
        public static void DontClear(params string[] arg)
        {
            dontClear.Clear();
            foreach (string s in arg)
            {
                dontClear.Add(s);
                Console.WriteLine(s);
            }
        }
        public static void DontClearMethod(Delegate @delegate)
        {
            dontClearMethod = @delegate;
        }
        public static string Swith(params string[] strings)
        {
            string selectedEnter = null; 
            bool need = false;
            int correntDown = -1;
            foreach(string s  in strings) 
            {
                Console.WriteLine(s);
            }
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    
                    correntDown++;
                    if (!need) { correntDown = 0; need = true; }
                    Console.Clear();
                    foreach(string dontClears in  dontClear)
                    {
                        Console.WriteLine(dontClears);
                    }
                    if(dontClearMethod != null)
                    {
                        dontClearMethod(CreatePersonThread.returnPerson());
                    }
                    int corrent = 0;
                    foreach (string s in strings) 
                    {
                        if (correntDown > strings.Length -1) { correntDown = 0; }
                        if (corrent == correntDown)
                        {
                            Console.WriteLine(Messeds.SELECTED + s);
                            selectedEnter = s;
                            corrent++;
                        }
                        else if(corrent != correntDown)
                        {
                            Console.WriteLine(s);
                            corrent++;
                        }
                        else
                        {
                            Console.WriteLine(s);
                        }
                    }
                    
                   
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    
                    correntDown--;
                    if (!need) { correntDown = strings.Length -1; need = true; }
                    Console.Clear();
                    foreach (string dontClears in dontClear)
                    {
                        Console.WriteLine(dontClears);
                    }
                    if (dontClearMethod != null)
                    {
                        dontClearMethod.Invoke(CreatePersonThread.returnPerson());
                    }
                    int corrent = 0;
                    foreach (string s in strings)
                    {
                        
                        if (correntDown == -1) { correntDown = strings.Length -1; }
                        if (corrent == correntDown)
                        {
                            Console.WriteLine(Messeds.SELECTED + s);
                            selectedEnter = s;
                            corrent++;
                        }
                        else if (corrent != correntDown)
                        {
                            Console.WriteLine(s);
                            corrent++;
                        }
                        else
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                if(key.Key == ConsoleKey.Enter) 
                {
                    if (selectedEnter != null)
                    {
                        Console.Clear();
                        dontClear.Clear();
                        return selectedEnter;
                    }
                }
                if(key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Тут должен быть инвентарь и другая инфа");
                }
            }
        }

        public static GameObjec Swith(List<GameObjec> gameObjecs)
        {
            
            GameObjec selectedEnter = null;
            bool need = false;
            int correntDown = -1;
            foreach (GameObjec s in gameObjecs)
            {
                if (s.touch)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(s.Name);
                    Console.ResetColor();
                }
                else if(s is PassIN)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine(s.Name);
                    Console.ResetColor();
                }
                else
                {


                    Console.WriteLine(s.Name);
                }
            }
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {

                    correntDown++;
                    if (!need) { correntDown = 0; need = true; }
                    Console.Clear();
                    foreach (string dontClears in dontClear)
                    {
                        Console.WriteLine(dontClears);
                    }
                    if (dontClearMethod != null)
                    {
                        dontClearMethod(CreatePersonThread.returnPerson());
                    }
                    int corrent = 0;
                    foreach (GameObjec s in gameObjecs)
                    {
                        if (correntDown > gameObjecs.Count - 1) { correntDown = 0; }
                        if (corrent == correntDown)
                        {
                            if (s.touch)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(Messeds.SELECTED + s.Name);
                                Console.ResetColor();
                            }
                            else if (s is PassIN) 
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(Messeds.SELECTED + s.Name);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(Messeds.SELECTED + s.Name);
                            }
                            selectedEnter = s;
                            corrent++;
                        }
                        else if (corrent != correntDown)
                        {
                            if (s.touch)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else if (s is PassIN)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(s.Name);
                            }
                            corrent++;
                        }
                        else
                        {
                            if (s.touch)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else if (s is PassIN)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else
                            {

                                Console.WriteLine(s.Name);
                            }
                        }
                    }


                }
                if (key.Key == ConsoleKey.UpArrow)
                {

                    correntDown--;
                    if (!need) { correntDown = gameObjecs.Count - 1; need = true; }
                    Console.Clear();
                    foreach (string dontClears in dontClear)
                    {
                        Console.WriteLine(dontClears);
                    }
                    if (dontClearMethod != null)
                    {
                        dontClearMethod.Invoke(CreatePersonThread.returnPerson());
                    }
                    int corrent = 0;
                    foreach (GameObjec s in gameObjecs)
                    {

                        if (correntDown == -1) { correntDown = gameObjecs.Count - 1; }
                        if (corrent == correntDown)
                        {
                            if (s.touch)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(Messeds.SELECTED + s.Name);
                                Console.ResetColor();
                            }
                            else if(s is PassIN)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(Messeds.SELECTED + s.Name);
                                Console.ResetColor();
                            }
                            else 
                            {
                                Console.WriteLine(Messeds.SELECTED + s.Name);
                            }
                            
                            selectedEnter = s;
                            corrent++;
                        }
                        else if (corrent != correntDown)
                        {
                            if (s.touch)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else if(s is PassIN)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(s.Name);
                            }
                            corrent++;
                        }
                        else
                        {
                            if (s.touch)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else if(s is PassIN)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(s.Name);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(s.Name);
                            }
                                
                        }
                    }
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (selectedEnter != null)
                    {
                        dontClear.Clear();
                        dontClearMethod = null;
                        Console.Clear();
                        return selectedEnter;
                    }
                }
                if(key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Тут должен быть инвентарь и другая инфа");
                }
            }
        }
    }
}
