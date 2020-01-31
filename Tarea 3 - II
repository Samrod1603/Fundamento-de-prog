using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese su salario mensual actual: ");
            double salario = double.Parse(Console.ReadLine());

            double canSmmlv = (salario / 877803);
            //Console.WriteLine("la cantidad de salarios minimos mensuales legales vigentes (SMMLV) es: " + canSmmlv);

            if (canSmmlv < 2)
            {
                Console.WriteLine("aplica a tarifa A, y por consulta general cancela 3.400");
            }

            else if (2 <= canSmmlv && canSmmlv < 5)
            {
                Console.WriteLine("aplica a tarifa B, y por consulta general cancela 13.500");
            }

            else
            {
                Console.WriteLine("aplica a tarifa C, y por consulta general cancela 35.600");
            }
        }
    }
}
        
 
