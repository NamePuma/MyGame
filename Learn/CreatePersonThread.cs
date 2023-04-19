using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class CreatePersonThread
    {
        private static CreatePerson creationPerson { get ; set; }
        public static CreatePerson returnPerson()
        {
            return creationPerson;
        }

        private Learn.CreatePerson.sex sexi;
        
        public CreatePersonThread() 
        {
            Music.Go("C:\\Users\\user\\source\\repos\\Learn\\Learn\\undertale_002. Start Menu.mp3");
            CreatePerson();
        }
        private void CreatePerson()
        {
            Console.WriteLine(Messeds.CREATE);
            Console.Write(Messeds.Name);
            string name = getName();

            Console.Write(Messeds.AGE);
            int age = getAge();

            Console.Clear();

            Whither.DontClear(Messeds.SEX);
            var sex = Whither.Swith("М", "Ж");
            if (sex != null)
            {
                if(sex == "М")
                {
                    sexi = Learn.CreatePerson.sex.man;
                }
                else
                {
                    sexi = Learn.CreatePerson.sex.wonam;
                }

            }
             creationPerson = new CreatePerson(name, age, sexi);

            Console.Clear();

            Whither.DontClear(Messeds.FINISHCREATEPERSON, Messeds.BORDER, creationPerson.Name, creationPerson.Age.ToString(), creationPerson.Sex.ToString(), Messeds.BORDER);
            while (true)
            {
                string answer = Whither.Swith(Messeds.NEXT, Messeds.CHANGE);
                if (answer == Messeds.NEXT)
                {


                    Console.Clear();
                    Music.Stop();
                    break;
                }
                else if (answer == Messeds.CHANGE)
                {

                    Console.Clear();
                    while (true)
                    {

                        Console.Clear();

                        Console.Write(Messeds.Name);
                        var newName = getName();
                        Console.WriteLine(Messeds.AGE);
                        int newAge = getAge();

                        Console.Clear();

                        Whither.DontClear(Messeds.SEX);
                        var newSex = Whither.Swith("М", "Ж");
                        if (newSex != null)
                        {
                            if (newSex == "М")
                            {
                                sexi = Learn.CreatePerson.sex.man;
                            }
                            else
                            {
                                sexi = Learn.CreatePerson.sex.wonam;
                            }
                        }
                        creationPerson.Change(newName, newAge, sexi);
                        Console.Clear();
                        Whither.DontClear(Messeds.FINISHCREATEPERSON, Messeds.BORDER, creationPerson.Name, creationPerson.Age.ToString(), creationPerson.Sex.ToString(), Messeds.BORDER);
                        break;
                    }

                }
                     
            }




            
        }
        
        private bool setAge(ref int age, string stringAge)
        {
            try
            {
                int intAge = int.Parse(stringAge);
            }
            catch
            {
                Console.WriteLine(Messeds.BORDER);
                Console.WriteLine(Messeds.EXCEPTIONNUMBER);
                return true;
            }
            age = int.Parse(stringAge);
            return false;
        } 
        private int getAge()
        {
            int age = 0;
            bool end = true;
            while (end)
            {
                end = setAge(ref age, Console.ReadLine());
            }
            return age;
        }
        private string getName()
        {
            string name = Console.ReadLine();
            if(name == "")
            {
                name = "Пупсик";
            }
            return name;
        }
    }
}
