using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnaLunder2020.Models
{
    public static class GuessRandom
    {
        public static int randomNumber;
        public static int i;
        
        public static string Guess(int guessNumber)
        {
            if (i == 0)
            {
                Random r = new Random();
                randomNumber = r.Next(1, 101);
            }
            
            string message = "";
                
            if (guessNumber > randomNumber)
            {
                i++;
                message = "Gissningen är för hög, försök igen!";
            }
            else if (guessNumber < randomNumber)
            {
                i++;
                message = "Gissningen är för låg, försök igen!";
            }
            else if (guessNumber == randomNumber)
            {
                i++;
                message = "Gissningen är korrekt!";
            }

            return message;
        }
    }
}