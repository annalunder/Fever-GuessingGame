using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Helpers
{
    public static class Fever
    {
        public static int temperature;
        public static string FeverCheck(int temperature)
        {
            string message = "";

            if (temperature > 37)
            {
                message = "You have a fever!";
            }

            else if (temperature <= 37)
            {
                message = "You are good to go!";
            }

            return message;
        }
    }
}
