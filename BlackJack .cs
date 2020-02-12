using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int total = 0;
            int cartas = 0;
            int i = 0;
            string continuar = "s";

            while (i < 1)
            {
                cartas = aleatorio.Next(1, 11);
                total += cartas;
                Console.WriteLine("esta fue su carta:" + cartas);
                Console.WriteLine("esete es su puntaje:" + total);
                i++;
            }
            while (continuar == "s" && total < 21)
            {
                cartas = aleatorio.Next(1, 11);
                total += cartas;
                Console.WriteLine("esta fue su carta:" + cartas);
                Console.WriteLine("este es su puntaje:" + total);
                if (total > 21)
                {
                    Console.WriteLine("valiste verga, perdiste" + total + "puntos");
                }
                else
                {
                    Console.WriteLine("desea continuar (s/n)");
                    continuar = Console.ReadLine();
                }
            }
        }
    }
}

        


