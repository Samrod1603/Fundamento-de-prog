using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int total = 0, turno = 0;
            bool condicion10 = false; 
                while (true)
            {
                int dado = aleatorio.Next(1, 13);
                if (dado%2 != 0 && turno >= 3) 
                {
                    Console.WriteLine("has perdido");
                    break;
                }
                if(total >= 100)
                {
                    Console.WriteLine("has ganado");
                    break; 
                }
                if (dado == 10)
                {
                    condicion10 = true;
                }
                if (dado != 10 && condicion10) 
                {
                    condicion10 = false;
                }
                if((condicion10 && dado == 12)||total >= 100)
                {
                    Console.WriteLine("has ganado");
                    break;
                }

            }
        }
    }
}
