using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U16_A2_calc_app
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputOne = 0;
            double inputTwo = 0;

            //this is the code that displays the title on the interface
            Console.WriteLine("###################################");
            Console.WriteLine("######## C# Calculator ############");
            Console.WriteLine("###################################");

            //this is what creates the loop
            bool calcLoop = true;
            while (calcLoop == true)
            {

                //this creates the mmenu interface
                Console.WriteLine("\nMenu");
                Console.WriteLine("Enter 1 for area of a square");
                Console.WriteLine("Enter 2 for area of triangle");
                Console.WriteLine("Enter 3 for area of circle");
                Console.WriteLine("Enter 4 for Support");
                Console.WriteLine("");
                int opChoice = Convert.ToInt32(Console.ReadLine());

                if (opChoice == 1)
                {
                    bool error = false;
                    while (error == false)
                    {

                        Console.Write("\nEnter your first number:  ");
                        string inputString = Console.ReadLine();

                        bool parsed1 = double.TryParse(inputString, out inputOne);

                        if (!parsed1)
                        {
                            Console.WriteLine("error");
                        }
                        else
                        {
                            error = true;
                        }


                    }

                    bool error2 = false;
                    while (error2 == false)


                        Console.Write("\nEnter your second number:  ");
                        string inputString2 = Console.ReadLine();

                        bool parsed2 = double.TryParse(inputString2, out inputTwo);

                    



                    if (!parsed2)
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        error2 = true;

                    }


                    if (opChoice == 2)
                    {



                        bool error3 = false;
                        while (error3 == false)
                        {

                            Console.Write("\nEnter your first number:  ");
                            string inputString3 = Console.ReadLine();

                            bool parsed1 = double.TryParse(inputString3, out inputOne);

                            if (!parsed1)
                            {
                                Console.WriteLine("error");
                            }
                            else
                            {
                                error3 = true;
                            }







                            bool error4 = false;
                            while (error4 == false)

                                Console.Write("\nEnter your second number:  ");
                            string inputString4 = Console.ReadLine();

                            bool parsed3 = double.TryParse(inputString4, out inputTwo);

                            if (!parsed3)
                            {
                                Console.WriteLine("error");
                            }
                            else
                            {
                                error4 = true;

                            }









                        }
                        if (opChoice == 4)


                        {
                            Console.WriteLine("Welcome to our support page");
                            Console.WriteLine("Step 1 - Enter the shape you want to calculate with the corresponding Number  ");
                            Console.WriteLine("Step 2a - if you have choesen option 1 or 2, Enter your first number");
                            Console.WriteLine("Step 3 - Then enter your second number");
                            Console.WriteLine("Step 2b - Enter only the radius");
                            Console.WriteLine("Step 4 - your answer should be given to 2 decimals if neccessary and will be displayed in the correct units");
                        }


                        if (opChoice == 3)
                        {


                            bool error5 = false;
                            while (error5 == false)

                                Console.Write("\nEnter your radius :  ");
                            string inputString4 = Console.ReadLine();

                            bool parsed4 = double.TryParse(inputString2, out inputTwo);

                            if (!parsed4)
                            {
                                Console.WriteLine("error");
                            }
                            else
                            {
                                error5 = true;

                            }



                        }

                        else
                            Console.Write("\nEnter a number from the list");

                        switch (opChoice)
                        {
                            case 1:
                                Console.WriteLine("You answer is " + inputOne * inputTwo);
                                break;

                            case 2:
                                Console.WriteLine("You answer is " + (inputOne * inputTwo) / 2);
                                break;

                            case 3:
                                Console.WriteLine("You answer is " + 3.14 * inputOne * inputOne);
                                break;





                        }
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
                            calcLoop = false;
                        }

                    }
                    Console.ReadKey();













                }
            }
        }
    }
}
            
