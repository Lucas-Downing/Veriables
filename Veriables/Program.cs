using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables:");

            int score;
            score = 0;

            Console.WriteLine(score);
            Console.WriteLine("score");

            score = score + 100;
            Console.WriteLine(score);



            

            // --------------------------------- STRINGS -----------------------------------------------------

            string name;
            name = "Lucas";
            Console.WriteLine(name);
            Console.WriteLine();
            string firstname;
            string lastname;
            string fullname;

            firstname = "Lucas"; //Declares firstname
            lastname = "Downing"; //declares lastname
            fullname = firstname + " " + lastname; //combines first and last name for the full name
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            Console.WriteLine(fullname);




            Console.ReadKey(true);
        }
    }
}
