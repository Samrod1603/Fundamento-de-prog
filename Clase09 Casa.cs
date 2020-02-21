using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int total = 0, vidas = 3, dado1 = 0,dado2=0, i = 0;
            string continuar = "s";

            while (continuar == "s") //&& total < 100)
            {
                Console.WriteLine("desea continuar (s/n):");
                continuar = Console.ReadLine();

                if (i % 3 == 0)
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    total += dado1 + dado2;
                }

                else
                {
                    dado1 = aleatorio.Next(1, 20);
                    total += dado1; 
                }

                Console.WriteLine("numero del dado: " + dado1);
                Console.WriteLine("puntaje total:" + total);
                                
                if (i%2 == 0 && i != 0)
                {
                    vidas -= 1;
                    Console.WriteLine("Perdíste una vida, Te quedan: " + vidas); 
                }
                if (dado1 == dado2 && i != 0)
                {
                    vidas += 1;
                    Console.WriteLine("conseguiste una vida, Te quedan: " + vidas); 
                }
                if (total >= 100)
                {
                    continuar = "F";
                    Console.WriteLine("has superado los 100 puntos, Ganaste!");
                }
                else if (vidas == 0)
                {
                    continuar = "F";
                    Console.WriteLine("perdiste todas tus vidas");
                }

                i++;
            }

            //int acabamos = 0;
            //Console.WriteLine("acabamos puto");
            //acabamos = int.Parse(Console.ReadLine());
        }
    }
}
