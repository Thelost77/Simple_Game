using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Simple_Game
{
    class Program
    {
        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number) || number > 100 || number < 0)
                {
                    Console.WriteLine("\nBłędna wartość, podaj wartość z przedziału od 0 do 100\n");
                    continue;
                }
                return number;

            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("\nWitaj, celem tej gry jest zgadnięcie losowej liczby w przedziale od 0 do 100.\n");
            var rnd = new Random();
            var goal = rnd.Next(100);
            int attemptCounter = 0;


            while (true)
            {
                Console.WriteLine("\nPodaj liczbę w zakresie od 0 do 100.\n");
                var choosenNumber = GetNumber();
                attemptCounter++; 

                if (choosenNumber > goal)
                { 
                    Console.WriteLine("\nTwoja liczba jest zbyt duża.\n");
                    System.Threading.Thread.Sleep(100); //Poprawa czytelności wyświetlanych w konsoli lini.
                    continue;
                }
                    
                else if (choosenNumber < goal)
                {
                    Console.WriteLine("\nTwoja liczba jest zbyt mała.\n");
                    System.Threading.Thread.Sleep(100);
                    continue;
                }
                    
                else
                {
                    Console.WriteLine($"\nBrawo zgadłeś! Twoja liczba to: {goal}\n");
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine($"\nUdało Ci się to w {attemptCounter} podejściach\n");
                    Console.ReadLine();
                    break;
                }
                    

            }
            
            
        }
    }
}
