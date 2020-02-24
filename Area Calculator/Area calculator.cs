using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_Modular_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator AreaCalc = new Calculator();

            Console.WriteLine("############################################################################");
            Console.WriteLine("###############    C#  A R E A  C A L C U L A T O R   ######################");
            Console.WriteLine("############################################################################");

            bool calcloop = true;
            while (calcloop == true)
            {
                //this for the user to choose what they want to calculate the area for//
                Console.WriteLine("\nMenu");
                Console.WriteLine("Enter 1 for RECTANGLE");
                Console.WriteLine("Enter 2 for TRIANGLE");
                Console.WriteLine("Enter 3 for CIRCLE");
                Console.WriteLine("Enter 4 for HELP");
                Console.WriteLine("");

                //user to input the numbers//
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        Console.WriteLine("Rectangle Area");
                        Console.WriteLine("--------------\n");
                        Console.Write("\nEnter your Length ");
                        double inputLength = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter your Width; ");
                        double inputWidth = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nYour answer is: " + AreaCalc.Rectangle(inputLength, inputWidth).ToString());
                        break;
                    case 2:
                        Console.WriteLine("Triangle Area");
                        Console.WriteLine("--------------\n");
                        Console.Write("\nEnter your first number: ");
                        double inputBase = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter your second number; ");
                        double inputHeight = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nYour answer is: " + AreaCalc.Triangle(inputHeight, inputBase).ToString());
                        break;
                    case 3:

                        Console.WriteLine("Circle Area");
                        Console.WriteLine("--------------\n");
                        Console.WriteLine("Please write the radius of your circle and hit Enter afterwards: ");
                        double radius = double.Parse(Console.ReadLine());
                        Console.WriteLine("The Area (A=πr2) of your circle is: " + AreaCalc.Circle(radius).ToString());
                        //help file for user to understand what they need to do//
                        break;
                    case 4:
                        Console.WriteLine("HELP FILE");
                        Console.WriteLine("---------");
                        Console.WriteLine("1. Input the shape you wnat to find the area of  ");
                        Console.WriteLine("2. Enter your first number ");
                        Console.WriteLine("3. Enter your second number ");
                        Console.WriteLine("4. Or enter the Radius ");
                        Console.WriteLine("5. View results ");
                        break;
                    default:
                        break;
                }
                //the user can calculate the area of another shape if they want//
                Console.WriteLine("");
                Console.Write("\nDo you want to try another sum? Y/N: ");
                string restartChoice = Console.ReadLine().ToUpper();

                if (restartChoice == "Y")
                {
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Press any key to exit");
                    calcloop = false;

                }

                Console.ReadKey();

            }


        }
    }
}