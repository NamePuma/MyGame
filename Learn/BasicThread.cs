using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class BasicThread
    {
        private bool exit {  get; set; } 
        public BasicThread() 
        {
            Thread();
        }
        private void Thread() 
        {
            stackMessegs();
            bool can = false;
            while (true)
            {
               var keyInfp =  Console.ReadKey(true);


                if(keyInfp.Key == ConsoleKey.DownArrow)
                {
                    if (can == true)
                    {
                        exit = stackMessegs(can);
                        can = false;
                    }
                    else
                    {
                        exit = stackMessegs(keyInfp);
                        can = true;
                    }
                }


                if(keyInfp.Key == ConsoleKey.UpArrow)
                {
                    if (can == false)
                    {
                        exit = stackMessegs(can);
                        can = true;
                    }
                    else
                    {
                        exit = stackMessegs(keyInfp);
                        can = false;
                    }
                }


                if(keyInfp.Key == ConsoleKey.Enter)
                {
                    if(exit == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        CreatePersonThread createPerson = new CreatePersonThread();
                        break;
                    }
                }
            }
        }
        private bool stackMessegs(in ConsoleKeyInfo key)
        {
            Console.Clear();
            Console.WriteLine(Messeds.HELLO);
            if (key.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine(Messeds.SELECTED + Messeds.ChooseStart);
                Console.WriteLine(Messeds.ChooseExit);
                return false;
            }
            if (key.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine(Messeds.ChooseStart);
                Console.WriteLine(Messeds.SELECTED + Messeds.ChooseExit);
                return true;
            }
            return false;
        }
        private void stackMessegs()
        {
            Console.WriteLine(Messeds.HELLO);
            Console.WriteLine(Messeds.ChooseStart);
            Console.WriteLine(Messeds.ChooseExit);
        }
        private bool stackMessegs(bool alt)
        {
            Console.Clear();
            if(alt == true) 
            {
                Console.WriteLine(Messeds.HELLO);
                Console.WriteLine(Messeds.ChooseStart);
                Console.WriteLine(Messeds.SELECTED + Messeds.ChooseExit);
                return true;
            }
            if(alt == false) 
            {
                Console.WriteLine(Messeds.HELLO);
                Console.WriteLine(Messeds.SELECTED + Messeds.ChooseStart);
                Console.WriteLine(Messeds.ChooseExit);
                return false;
            }
            return false;
            
        }
    }
}
