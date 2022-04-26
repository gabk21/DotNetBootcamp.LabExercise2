using System;

namespace CSharp.LabExercise2
{
    class Lasagna
    {
        public void ExpectedMinutesInOven()
        {
            Console.WriteLine("Expected time in the oven: 40 minutes");
        }

        public void RemainingMinutesInOven(int num1)
        {
            int remainingMinutesInOven = 40 - num1;
            Console.WriteLine($"{remainingMinutesInOven}");
        }

        public void PreparationTimeInMinutes(int num2)
        {
            int preparationTimeInMinutes = num2 * 2;
            Console.WriteLine($"Time spent in preparation of lasagna is: {preparationTimeInMinutes} minutes.");
        }

        public void ElapsedTimeInMinutes(int num3, int num4)
        {
            int elapsedTimeInMinutes = (num3 * 2) + num4;
            Console.WriteLine($"\nElapsed time cooking the lasagna is: {elapsedTimeInMinutes} minutes.");
        }
    }
    class Program
    {
        static void Number1()
        {
            int minNum = 10;
            int maxNum = 100;
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("\nEnter a number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                if (array[i] > maxNum || array[i] < minNum)
                {
                    Console.WriteLine("Number must be between 10 and 100");
                    i--;
                    continue;
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (array[i] == array[j])
                        {
                            Console.WriteLine($"\n{array[i]} has already been entered");
                            i--;
                            break;
                        }
                    }
                }
                for (int index = 0; index < i + 1; index++)
                {
                    Console.Write($"\n{array[index]}");
                }
            }
        }

        static void Number2()
        {
            string chooseAgain = "y";

            Console.WriteLine("Cooking Lasagna bot assistant \nPlease choose a number\n");
            while (chooseAgain == "y" || chooseAgain == "Y")
            {
                Console.WriteLine("[1] Expected oven time in minutes");
                Console.WriteLine("[2] Remaining oven time in minutes");
                Console.WriteLine("[3] Preparation time in minutes");
                Console.WriteLine("[4] Elapsed time in minutes");

                int userChoice = Convert.ToInt32(Console.ReadLine());
                var lasagna = new Lasagna();
                Console.WriteLine(" ");

            
                if (userChoice == 1)
                {
                    lasagna.ExpectedMinutesInOven();
                }

                else if (userChoice == 2)
                {
                    Console.WriteLine("How long has been the lasagna inside the oven?");
                    int time1 = Convert.ToInt32(Console.ReadLine());
                    if (time1 == 40)
                    {
                        Console.WriteLine("\nLasagna is now fully cooked.");
                    }
                    else if (time1 > 40)
                    {
                        Console.WriteLine("\nLasagna is overcooked!");
                    }
                    else if (time1 < 40)
                    {
                        Console.WriteLine("\nTime remaining is:");
                        lasagna.RemainingMinutesInOven(time1);
                    }
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("How many layers did you add to the lasagna?");
                    int layer1 = Convert.ToInt32(Console.ReadLine());
                    lasagna.PreparationTimeInMinutes(layer1);
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("How many layers did you add to the lasagna?");
                    int layer2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nHow long is the lasagna inside the oven?");
                    int time2 = Convert.ToInt32(Console.ReadLine());

                    if (time2 == 40)
                    {
                        lasagna.ElapsedTimeInMinutes(layer2, time2);
                        Console.WriteLine("\nLasagna now fully cooked.");
                    }
                    else if (time2 < 40)
                    {
                        lasagna.ElapsedTimeInMinutes(layer2, time2);
                    }
                    else if (time2 > 40)
                    {
                        lasagna.ElapsedTimeInMinutes(layer2, time2);
                        Console.WriteLine("\nLasagna is overcooked.");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine("\nChoose again? (y/n)");
                chooseAgain = Console.ReadLine();

                if (chooseAgain == "n" || chooseAgain == "N")
                {
                    Environment.Exit(1);
                }
            }
        }


        static void Main(string[] args)
        {
            //Number1();
            Number2();
        }
    }
}
