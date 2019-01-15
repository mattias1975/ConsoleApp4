using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var KeepAlive = true;
            while (KeepAlive)
            {
                try
                {
                    Console.Write("Enter a assigment number (or -1 to exit ): ");
                    var assigmentChoise = ConsoleColor.Green;
                    switch (assigmentChoise)
                    {
                        case 1:
                            RunExerciseONE();
                            break;
                        case 2:
                            RunExerciseTWO();
                            break;

                        case 3:
                            RunExerciseThree();
                            break;
                        case -1:
                            KeepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("that is not a valid assigment number! ");
                            break;

                            Console.ResetColor();

                            Console.WriteLine("Hit any key to continue ");
                            Console.ReadKey();
                            Console.Clear();
                    }
                    
                            catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("that is not a valid assigment number ");
                    Console.ResetColor();
                }
            }
        
    

        
   
