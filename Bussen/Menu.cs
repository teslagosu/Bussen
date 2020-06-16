using System;
using System.Collections.Generic;
using System.Text;

namespace Bussen
{
    public class Menu
    {
        Bus bus = new Bus();
        public Menu()
        {
            
        }

        public void run()
        {


            while (true)
            {
                // Console.Clear();
                Console.WriteLine("=== Välkommen till bussen! ===");
                Console.WriteLine("\nVar vänlig och välja alternativ\n" +
                                  "I menyn nedanför.\n" +
                                  "[L] Lägg till Passagerare\n" +
                                  "[T] Ta bort Passagerare\n" +
                                  "[K] Kolla vilka Passagerare som sitter i.\n" +
                                  "[P] Passagerar alternativ\n" +
                                  "[A] Avslut");
                Console.WriteLine(" ");
                ConsoleKeyInfo inputFromUser = Console.ReadKey(true);
                // string inputFromUser = Console.ReadLine();
                switch (inputFromUser.Key)
                {
                    // Lägger till passagerare
                    case ConsoleKey.L:
                        {
                            Console.WriteLine("APA");

                            Console.WriteLine("Passagerares namn: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Passagerare ålder: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Passagerares yrke: ");
                            string profession = Console.ReadLine();
                            Person person = new Person(name, age, profession);

                            if (bus.checkIfBusIsFull())
                            {
                                Console.WriteLine("Bussen är full!");
                                break;
                            }
                            else
                            {
                                bus.addPassenger(person);
                                break;
                            }
                        }
                    case ConsoleKey.T:
                        {
                            Console.WriteLine("Välj en passagerare som ska lämna bussen: ");
                            //print persons removable
                            bus.removablePassengers();
                            //input from user
                            int index = Convert.ToInt32(Console.ReadLine());
                            //pass in the index of the passenger to be removed.
                            bus.removePassenger(index - 1);
                            break;
                        }

                    // Kolla vilka passagerare som sitter i
                    case ConsoleKey.K:
                        {
                            Console.WriteLine("=== Personer på bussen ===");
                            bus.printPassengers();
                            Console.WriteLine("");
                            break;
                        }

                    // Sub-menu
                    case ConsoleKey.P:
                        {
                            Console.WriteLine("===== Passagerar alternativ =====");
                            Console.WriteLine("  [F] Hitta passagerare med specifik ålder\n" +
                                              "  [T] Totala åldern av passagerarna\n" +
                                              "  [S] Snitt åldern på alla passagerare\n" +
                                              "  [M] Vem som är äldst av passagerarna\n" +
                                              "  [Z] Sortera bussen efter Ålder\n" +
                                              "  [P] Peka på någon\n" +
                                              "  [K] Kön på de i Bussen\n" +
                                              "  [R] Tillbaka till Main menu");
                            Console.WriteLine(" ");
                            ConsoleKeyInfo inputFromUserUndermenu = Console.ReadKey(true);
                            switch (inputFromUserUndermenu.Key)
                            {
                                // Hitta passagerare med specifik ålder
                                case ConsoleKey.F:
                                    {
                                        Console.WriteLine("===== Skriv in åldern på passageraren du söker =====");
                                        int age = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine(bus.findAge(age));
                                        break;
                                    }

                                // Totala åldern
                                case ConsoleKey.T:
                                    {
                                        bus.totalAge();
                                        break;
                                    }
                                // Snitt åldern av alla
                                case ConsoleKey.S:
                                    {
                                        bus.averageAge();
                                        break;
                                    }





                            }
                            break;
                        }
                }
            }
        }
    }
                    
}
