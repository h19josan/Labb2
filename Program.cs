using System;
using System.Collections.Generic;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string name, int age)> familymembers = new List<(string, int)>();
            bool menuSelect = true;
            int totalAge = 0;
            // Jag har tagit inspiration från Elins labb2 instruktioner om menyn
            // Jag har använt mig av C# skolan för information om list och intParse/tryParse
            while (menuSelect)
            {
                Console.WriteLine("\nVälj ett alternativ:");
                Console.WriteLine("1. Lägg till familjemedlem");
                Console.WriteLine("2. Visa alla familjemedlemmar");
                Console.WriteLine("3. Visa summan av åldrarna");
                Console.WriteLine("4. Visa medelåldern");
                Console.WriteLine("5. Avsluta programmet");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Skriv in namn: ");
                            string name = Console.ReadLine();
                            Console.Write("Skriv in ålder: ");
                            int age = int.Parse(Console.ReadLine());
                            familymembers.Add((name, age));
                            break;

                        case 2:
                            Console.WriteLine("\nAlla familjemedlemmar:");
                            for (int i = 0; i < familymembers.Count; i++)
                            {
                                Console.WriteLine($"{familymembers[i].name}, {familymembers[i].age} år");
                            }
                            break;

                        case 3:

                            totalAge = 0;
                            for (int i = 0; i < familymembers.Count; i++)
                            {
                                totalAge += familymembers[i].age;
                            }
                            Console.WriteLine($"\nSumman av åldrarna är: {totalAge} år");
                            break;

                        case 4:
                            if (familymembers.Count > 0)
                            {
                                double averageAge = (double)totalAge / familymembers.Count;
                                Console.WriteLine($"\nMedelåldern är: {averageAge:F2} år");
                            }
                            else
                            {
                                Console.WriteLine("\nInga familjemedlemmar tillagda ännu.");
                            }
                            break;

                        case 5:
                            menuSelect = false;
                            Console.WriteLine("\nProgrammet avslutas...");
                            break;

                        default:
                            Console.WriteLine("\nOgiltigt val, försök igen.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOgiltigt val, försök igen.");
                }
            }
        }
    }
}
