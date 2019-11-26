using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace in_class4
{
    class Menu
    {
        public void executeMenu()
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

                if (userOp == "3")
                {
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
                else if (userOp == "1")
                {
                    animalSelect("Monkey");
                }
                else if (userOp == "2")
                {
                    animalSelect("Bear");
                }
                else
                {
                    errorHandle();
                    executeMenu();
                }
        }

        public void animalSelect(string userAnimal)
        {
            Console.WriteLine("");
            Console.WriteLine("{0} Menu: ", userAnimal);
            Console.WriteLine("================");
            Console.WriteLine("");

            Console.WriteLine("Species: ");
            Console.WriteLine("-------------");
            Console.WriteLine("");

            if (userAnimal == "Monkey")
             {
                    Console.WriteLine("1.Squirrel");
                    Console.WriteLine("2.Howler");
                    Console.WriteLine("3.Colobus");

                    Console.WriteLine("");
                    Console.WriteLine("Select: ");

                    string userOp = Console.ReadLine();

                if (userOp == "1")
                {
                    Console.WriteLine("Enter your monkey's weight (kilograms): ");
                    string weight = Console.ReadLine();
                    Monkey myChoice = new Monkey("Squirrel", weight);
                    printAnimal(myChoice);
                }
                else if (userOp == "2")
                {
                    Console.WriteLine("Enter your monkey's weight (kilograms): ");
                    string weight = Console.ReadLine();
                    Monkey myChoice = new Monkey("Howler", weight);
                    printAnimal(myChoice);
                }
                else if (userOp == "3")
                {
                    Console.WriteLine("Enter your monkey's weight (kilograms): ");
                    string weight = Console.ReadLine();
                    Monkey myChoice = new Monkey("Colobus", weight);
                    printAnimal(myChoice);
                }
                else
                {
                    errorHandle();
                    animalSelect("Monkey");
                }
            }
            else if (userAnimal == "Bear")
            {
                Console.WriteLine("1.Polar");
                Console.WriteLine("2.Black");
                Console.WriteLine("3.Grizzly");

                Console.WriteLine("");
                Console.WriteLine("Select: ");

                string userOp = Console.ReadLine();

                if (userOp == "1")
                {
                    Console.WriteLine("Enter your bear's weight (kilograms): ");
                    string weight = Console.ReadLine();
                    Bear myChoice = new Bear("Polar", weight);
                    printAnimal(myChoice);
                }
                else if (userOp == "2")
                {
                    Console.WriteLine("Enter your monkey's weight (kilograms): ");
                    string weight = Console.ReadLine();
                    Bear myChoice = new Bear("Black", weight);
                    printAnimal(myChoice);
                }
                else if (userOp == "3")
                {
                    Console.WriteLine("Enter your monkey's weight (kilograms): ");
                    string weight = Console.ReadLine();
                    Bear myChoice = new Bear("Grizzly", weight);
                    printAnimal(myChoice);
                }
                else
                {
                    errorHandle();
                    animalSelect("Bear");
                }
            }
        }

        public void printAnimal(Mammal userSelect)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------");
            Console.WriteLine("Meal Recomendation");
            Console.WriteLine("------------");
            Console.WriteLine("Mammal Type: {0}", userSelect.MammalName);
            Console.WriteLine("Species Type: {0}", userSelect.SpeciesName);
            Console.WriteLine("Weight: {0}", userSelect.Weight);
            Console.WriteLine("Serving: {0} KG {1}.", userSelect.GetServing(userSelect.Weight), userSelect.Diet);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Instructions:  {0}", userSelect.Note);
            Console.WriteLine(" {0}", userSelect.FeedNote);
            Console.WriteLine("");
            Console.WriteLine("Press 1 to return to the menu. Press any key to exit program.");
            Console.WriteLine("");
            string userOp = Console.ReadLine();

            if (userOp == "1")
            {
                executeMenu();
            }
            else
            {
                Console.WriteLine("Good bye");
                Environment.Exit(0);
            }
        }
        public void errorHandle()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please pick a valid selection.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------");
        }
    }
}
