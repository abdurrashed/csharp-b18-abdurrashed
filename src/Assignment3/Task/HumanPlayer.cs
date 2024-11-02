using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Task
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string Name, int numberofpawns) : base(Name, numberofpawns)
        {
            

        }

        public override bool CanUnlockPawn()
        {
            if (pawnsplay < Pawnpositions.Length)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

        public override void Movepawn(int value)
        {
            if (pawnsplay > 0)
            {
                Console.WriteLine($"Enter the pawn number (1-{pawnsplay}) for move ");
                int pawn = int.Parse(Console.ReadLine());
                if (pawn <= pawnsplay&&pawn>0)
                {
                    Pawnpositions[pawn - 1] += value;
                    Console.WriteLine($"{Name}'s {pawn} pawn moved to {Pawnpositions[pawn - 1]}.");
                }
              
                

            }
            else
            {
                Console.WriteLine($"{Name} has no pawns in play");

            }
          

        }

        public override int Roll()
        {
            Console.WriteLine($"{Name},Please press Enter to Roll the dice");
            Console.ReadKey();
            Dice dice = new Dice();
            return dice.Roll();
            
        }
      
  

        public override void UnlockPawn()
        {
            if (pawnsplay < Pawnpositions.Length)
            {
                Pawnpositions[pawnsplay] = 0;

                pawnsplay++;
                Console.WriteLine($"{Name} uncloked a pawn and moved it at starting position ");
            }
            else
            {
                Console.WriteLine($"{Name} has no pawn left to unclock");
            }

        }
    }
}


