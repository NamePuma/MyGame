using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public abstract class GameObjec
    {
        
        protected string name; 
        protected string description;
        protected bool movie;
        public bool touch { get; protected set; }
        public virtual string Name { get => name; protected set => name = value; }
        public virtual string Description { get => description; protected set => description = value;}
        public virtual bool Movie { get => movie; protected set => movie = value;}
        
        

        public abstract void Reaction(CreatePerson person);

        public abstract void Action(CreatePerson person);

        
        
       

        

    }
}
