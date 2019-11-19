using System;
using System.Collections.Generic;
using System.Text;

namespace in_class4
{
    class Menu
    {

    public void executeGame()

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
                else if (userOp == "1")
                {
                    monkeySelect();
                    Console.ReadLine();
                }
                else if (userOp == "2")
                {
                    bearSelect();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a valid selection.");
                    userOp = Console.ReadLine();

                }
            } while (gamePlay != "3");
        }


    public static void monkeySelect()
{
    Console.WriteLine("");
    Console.WriteLine("Monkey Menu: ");
    Console.WriteLine("================");
    Console.WriteLine("");


    Console.WriteLine("Species: ");
    Console.WriteLine("-------------");
    Console.WriteLine("");

    Console.WriteLine("1.Squirrel");
    Console.WriteLine("2.Howler");
    Console.WriteLine("3.Colobus");

    Console.WriteLine("");
    Console.WriteLine("Select: ");
}


public static void bearSelect()
{
    Console.WriteLine("");
    Console.WriteLine("Bear Menu: ");
    Console.WriteLine("================");
    Console.WriteLine("");


    Console.WriteLine("Species: ");
    Console.WriteLine("-------------");
    Console.WriteLine("");

    Console.WriteLine("1.Polar");
    Console.WriteLine("2.Black");
    Console.WriteLine("3.Grizzly");

    Console.WriteLine("");
    Console.WriteLine("Select: ");
}


    }
}
