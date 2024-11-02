using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Dice
    {
     
         public int Roll()
        {

            return new Random().Next(1, 7);
        } 

    }
}
