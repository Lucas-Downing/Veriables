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

            //-----------------FLOATS-----------------------------

            float speed;
            float distanceTravelled;
            speed = 100.00f;
            distanceTravelled = 0.0f;

            Console.WriteLine("Speedometer: " + speed);
            Console.WriteLine("Odometer: " + distanceTravelled);

            //---------------------INTS vs. FLOATS-----------------------

            int test1;
            float test2;
            test1 = 10 / 3;
            test2 = 10.0f / 3.0f;

            Console.WriteLine(test1);
            Console.WriteLine(test2);

            Console.WriteLine();
            Console.WriteLine("-------Bye Bye-------");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
        }
    }
}
