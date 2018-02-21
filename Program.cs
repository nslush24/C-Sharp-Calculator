using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nate Schlusler
            // CIT 110 
            // The Calculator Using Loop
            



            // variables
            double operand1, operand2;
            double answer = 0;
            string operation;
            string symbol;
            string userResponse;
            bool validOperation = false;
            double infinity = double.PositiveInfinity;
            

            // start calculator loop
            while (true)
            {

                Console.Clear();

                // get operand 1
                Console.WriteLine("Operand 1:");
                Console.WriteLine();
                userResponse = Console.ReadLine();
                while (!double.TryParse(userResponse, out operand1))
                {
                    Console.WriteLine();
                    Console.WriteLine("Your must enter a number please try again");
                    Console.WriteLine();
                    Console.WriteLine("Operand 1:");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                }

                // get operand 2
                Console.WriteLine();
                Console.WriteLine("Operand 2");
                Console.WriteLine();
                userResponse = Console.ReadLine();
                while (!double.TryParse(userResponse, out operand2))
                {

                    Console.WriteLine("Your must enter a number please try again");
                    Console.WriteLine();
                    Console.WriteLine("Operand 2:");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                }


                // get operation using do while
                do
                {
                    validOperation = true;
                    Console.WriteLine();
                    Console.WriteLine("Enter Operation (add, subtract, multiply, divide):");
                    Console.WriteLine();
                    operation = Console.ReadLine().ToUpper();
                    symbol = Console.ReadLine();
                    if (operation == "ADD" ||
                        operation == "SUBTRACT" ||
                        operation == "DIVIDE" ||
                        operation == "MULTIPLY")
                    {
                        Console.WriteLine($"You have selected {operation}. ");
                    }

                    else {
                        Console.WriteLine();
                        Console.WriteLine("Please enter a valid selection");
                        validOperation = false;
                        Console.WriteLine();

                    }
                    Console.WriteLine();
                    Console.WriteLine("Press any key to display answer.");
                    Console.ReadKey();



                } while (!validOperation);

                switch (operation)
                {
                    case "ADD":
                        answer = operand1 + operand2;
                        symbol = "+";
                        break;
                    case "SUBTRACT":
                        answer = operand1 - operand2;
                        symbol = "-";
                        break;
                    case "DIVIDE":
                        answer = operand1 / operand2;
                        symbol = "/";
                        break;
                    case "MULTIPLY":
                        answer = operand1 * operand2;
                        symbol = "*";
                        break;

                    default:
                            Console.WriteLine("Invalid choice");
                            break;
                        };
                // number divide by 0 validation

                while (answer == infinity)
                {
                    Console.Clear();
                    Console.WriteLine("Cannot divide a number by 0.");
                    Console.WriteLine();
                    // get operand 1
                    Console.WriteLine("Operand 1:");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();
                    while (!double.TryParse(userResponse, out operand1))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your must enter a number please try again");
                        Console.WriteLine();
                        Console.WriteLine("Operand 1:");
                        Console.WriteLine();
                        userResponse = Console.ReadLine();

                    }
                    Console.WriteLine();
                    // get operand 2
                    Console.WriteLine("Operand 2");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();
                    while (!double.TryParse(userResponse, out operand2))
                    {

                        Console.WriteLine("Your must enter a number please try again");
                        Console.WriteLine();
                        Console.WriteLine("Operand 2:");
                        Console.WriteLine();
                        userResponse = Console.ReadLine();

                    }


                    // get operation using do while
                    do
                    {
                        validOperation = true;
                        Console.WriteLine();
                        Console.WriteLine("Enter Operation (add, subtract, multiply, divide):");
                        Console.WriteLine();
                        operation = Console.ReadLine().ToUpper();
                        symbol = Console.ReadLine();
                        if (operation == "ADD" ||
                            operation == "SUBTRACT" ||
                            operation == "DIVIDE" ||
                            operation == "MULTIPLY")
                        {
                            Console.WriteLine($"You have selected {operation}. ");
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a valid selection");
                            validOperation = false;
                            Console.WriteLine();

                        }
                        Console.WriteLine();
                        Console.WriteLine("Press any key to display answer.");
                        Console.ReadKey();



                    } while (!validOperation);

                    switch (operation)
                    {
                        case "ADD":
                            answer = operand1 + operand2;
                            symbol = "+";
                            break;
                        case "SUBTRACT":
                            answer = operand1 - operand2;
                            symbol = "-";
                            break;
                        case "DIVIDE":
                            answer = operand1 / operand2;
                            symbol = "/";
                            break;
                        case "MULTIPLY":
                            answer = operand1 * operand2;
                            symbol = "*";
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    };
                }
                
                
                
                // display answer
                Console.WriteLine();
                Console.WriteLine($"{operand1} {symbol} {operand2} = {answer}");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                // end application

                        Console.WriteLine();
                        Console.WriteLine("Press s to exit application. Otherwise, press any key to restart calculator.");
                        userResponse = Console.ReadLine().ToUpper();
                        if (userResponse == "S")
                        {
                            Environment.Exit(0);

                        }



                }



            }
        }
    }

    

