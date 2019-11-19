using System;

namespace in_class4
{
    class Program
    {
        static void Main(string[] args)
        {

            string gamePlay = "";

            do
            {
                Console.WriteLine("================");
                Console.WriteLine("Zoo Menu Planner");
                Console.WriteLine("================");
                Console.WriteLine("");
                Console.WriteLine("Select species: ");
                Console.WriteLine("");
                Console.WriteLine("1. Monkey");
                Console.WriteLine("2. Bear");
                Console.WriteLine("3. Quit");
                Console.WriteLine("");
                Console.WriteLine("Select: ");

                String userOp = Console.ReadLine();
                gamePlay = userOp;

                if (userOp == "3")
                {
                    Console.WriteLine("Goodbye");
                }

            } while (gamePlay != "3");
        }

    }
}
