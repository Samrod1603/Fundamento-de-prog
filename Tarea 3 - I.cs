using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        { 
            //ingreso de datos
            Console.WriteLine("ingrese su salario (smmlv) para verificar su tarifa");
            double smmlv = double.Parse(Console.ReadLine());

            //salida
            if (smmlv < 2)
            {
                Console.WriteLine("Aplica para la tarifa A");
            }
            else if (2 <= smmlv && smmlv <= 4)
            {
                Console.WriteLine("Aplica para la Tarifa B");
            }
            else
            {
                Console.WriteLine("Aplica para la tarifa C"); 
            }
        }
    }
}
