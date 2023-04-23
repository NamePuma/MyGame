using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Learn.GameObjectWithCount;

namespace Learn
{
    internal class GameObjectWithCount : GameObjec
    {
        public delegate void Movies(); 
        protected int Count { get; private set; } = 0;

        private bool haveMove = false;

        private Movies[] MoviesOn;

        public GameObjectWithCount(string name, string descr,params Movies[] movies)
        {
            Name = name;
            Description = descr;
            
            MoviesOn = movies;
            if(MoviesOn.Length >= 2) 
            {
                haveMove = true;
            }
                
            
           

        }   

        public override void Reaction(CreatePerson person)
        {
            if(Count == 0)
            {
                if (MoviesOn.Length > 0)
                {
                    MoviesOn[Count].Invoke();
                }
                else
                {
                    Console.WriteLine(Description);
                    touch = true;
                }
                if (haveMove)
                {
                    Count++;
                }
            }
            else
            {
                Reaction(MoviesOn);
            }

        }
        public virtual void Reaction(params Movies[] moviesOn)
        {
            
            if (Count >= moviesOn.Length) { moviesOn[Count -1].Invoke(); return; }
            moviesOn[Count].Invoke();
            Count++;
            if(Count >= moviesOn.Length)
            {
                touch = true;
            }
        }

    }
}
