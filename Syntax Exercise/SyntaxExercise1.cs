using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Exercise
{
    internal class SyntaxExercise1
    {
        static void Main(string[] args)
        {
            // change following code to implement Inferred typing, string interpolation and ternary operator
            //     int answer = 4;
            //     string response;
            //     if (answer < 9 )
            //  {
            //     response = answer + "is less thank nine";
            //  }
            //     else
            //  {
            //     response = answer + "is greater than or equal to nine";
            //  }

            var answer = 4;
            string response;

            response = (answer < 4) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);







        }

    }
}
