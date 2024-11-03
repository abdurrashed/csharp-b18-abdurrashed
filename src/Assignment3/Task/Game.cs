using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Game
    {
        public Player[] Contestants { get; set; }
        public int PlayerNumber { get; set; }
        public int LargestDiceSide { get; private set; } = 6;
        public bool MatchStart { get; set; }  = true;
        public void Start()
        {
            HomePage();
            SetupPlayers();
            GameSessionStart();
        }

        private void HomePage()
        {
            Console.WriteLine("Welcome to Ludo Game!");
            Console.WriteLine("Press Enter to start...");

            Console.ReadLine();
            Console.Clear();
        }

        private void SetupPlayers()
        {
            Console.WriteLine("Enter the Number of Players(2-4) ");
            PlayerNumber = int.Parse(Console.ReadLine());
            Contestants = new Player[PlayerNumber];

            for (int i = 0; i < PlayerNumber; i++)
            {
                Console.WriteLine($"Enter the name of player {i + 1}");
                string name = Console.ReadLine();
                Console.WriteLine($"{name} is human ? Enter the (y/n) ");
                bool ishuman = Console.ReadLine().ToLower() == "y";
                Console.WriteLine("Enter the number of pawn of this this player: ");
                int numberofpawns = int.Parse(Console.ReadLine());


                if (ishuman)
                {
                    Contestants[i] = new HumanPlayer(name, numberofpawns);


                }
                else
                {

                    Contestants[i] = new AIPlayer(name, numberofpawns);

                }


            }



        }

        private void GameSessionStart()
        {
            while (MatchStart)
            {
                for (int i = 0; i < PlayerNumber; i++)
                {
                    Player currenplayer = Contestants[i];
                    Console.WriteLine($"{currenplayer.Name} is rolling dice");
                    int dicevalue = currenplayer.Roll();
                    Console.WriteLine($"{currenplayer.Name} got {dicevalue}");
                    CheckUnlock(ref currenplayer, dicevalue);

                }
            }



        }
         public  void  CheckUnlock(ref  Player player ,  int value )
        {
            if (value == LargestDiceSide)
            {
                if (player is HumanPlayer)
                {
                    string unlock;
                    Console.WriteLine("DO YOU WANT TO UNLOCK A PAWN? PRESS 'y' TO UNLOCK AND 'n' TO SKIP");
                    unlock = Console.ReadLine().ToLower();
                    if (unlock == "y")
                    {
                        if (player.CanUnlockPawn())
                        {
                            player.UnlockPawn();
                        }
                        value = player.Roll();
                        Console.WriteLine($"{player.Name} Got {value}");

                        player.Movepawn(value);

                    }

                }

                else
                {
                    if (player.CanUnlockPawn())
                    {
                        player.UnlockPawn();

                    }
                    value = player.Roll();
                    Console.WriteLine($"{player.Name} Got {value}");

                    player.Movepawn(value);


                }
            }
            else
            {
                player.Movepawn(value);

            }
             



        }

    }
}


