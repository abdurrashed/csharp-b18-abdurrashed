using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int pawnsplay;
        public int[] Pawnpositions { get; private set; }

        public Player(string Name, int numberofpawns)
        {
            this.Name = Name;
            this.Pawnpositions = new int[numberofpawns];
            pawnsplay = 0;
            
        }
 

        public abstract int Roll();
        public abstract void UnlockPawn();
        public abstract bool CanUnlockPawn();
        public abstract void Movepawn(int value);
        





    }
}
