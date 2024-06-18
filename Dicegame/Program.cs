using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int matheeshaRandomNum;
            int kushmiRandomNum;

            int matheeshaPoints = 0;
            int kushmiPoints = 0;

            Random random= new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                matheeshaRandomNum = random.Next(1, 7);
                Console.WriteLine("Matheesha rolled a " + matheeshaRandomNum);

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(1000);

                kushmiRandomNum = random.Next(1, 7);
                Console.WriteLine("Kushmi rolled a " + kushmiRandomNum);

                if (matheeshaRandomNum > kushmiRandomNum)
                {
                    matheeshaPoints++;
                    Console.WriteLine("Matheesha wins this round!");
                }
                else if (matheeshaRandomNum < kushmiRandomNum)
                {
                    kushmiPoints++;
                    Console.WriteLine("Kushmi wins this round");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now => Matheesha : " + matheeshaPoints + " | Kushmi : " + kushmiPoints + ".");
                Console.WriteLine();
            }

            if(matheeshaPoints > kushmiPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(matheeshaPoints< kushmiPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();
           
        }
    }
}
