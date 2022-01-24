using System;

namespace MySimpleCalc
{
    public static class Calculator
    {
        public static void Main()
        {
            Console.WriteLine("Choose One of The Following Operations (+, -, *, /)");

            var operation = Console.ReadKey().KeyChar;

            Console.WriteLine("\n");

            switch (operation)
            {
                case '+':
                    Console.WriteLine("Addition\n");
                    int countInt = 0;

                    Console.WriteLine("How many numbers would you like to add?");
                    var count = Console.ReadLine();
                    int.TryParse(count, out countInt);

                    int resultAdd = 0;
                    
                    for (int i = 1; i <= countInt; i++)
                    {
                        var parseSucceeded = false;
                        int num = 0;

                        while (!parseSucceeded)
                        {
                            Console.WriteLine($"Enter number {i}: ");
                            var input1 = Console.ReadLine();
                            parseSucceeded = int.TryParse(input1, out num);

                            if (!parseSucceeded)
                                Console.WriteLine("Please enter a number.");
                        }
                        resultAdd += num;
                    }

                    Console.WriteLine(resultAdd);

                    break;
                case '-':
                    Console.WriteLine("subtraction");

                    Console.WriteLine("enter number 1");
                    var num1 = Console.ReadLine();
                    int num1converted = 0;
                    int.TryParse(num1, out num1converted);

                    Console.WriteLine("enter number 2");
                    var num2 = Console.ReadLine();
                    int num2converted = 0;
                    int.TryParse(num2, out num2converted);

                    var resultSub = num1converted - num2converted;
                    Console.WriteLine(resultSub);
                    break;
                case '*':
                    Console.WriteLine("multiplication");
                    break;
                case '/':
                    Console.WriteLine("division");
                    break;
                default:
                    Console.WriteLine("please select one of the operations");
                    break;
            }


        }
    }
}