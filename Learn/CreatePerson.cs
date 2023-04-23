using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public class CreatePerson : IPerson
    {
        public enum sex { man, wonam}
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Balance { get; private set; } = 30;

        public int health { get; private set; } = 100;
        public Enum Sex { get; private set; }

        public List<GameObjec> Inventory { get; private set; } = new List<GameObjec>();

        public CreatePerson(string name, int age, sex sex)
        {
         Name = name;
         Age = age;
         if(sex == sex.man) 
            {
                Sex = CreatePerson.sex.man;
            }
         else
            {
                Sex = CreatePerson.sex.wonam;
            }
        }
        public void Change(string newName, int newAge, sex newSex)
        {
            Name = newName;
            Age = newAge;
            Sex = newSex;

        }
        public void GiveInInventory(GameObjec item)
        {
            if (item != null) {
                
                Inventory.Add(item);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(item.Name + " был добавлен в инвентарь!");
                Console.ResetColor();
            }
        }

    }
}
