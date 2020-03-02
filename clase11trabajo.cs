using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de datos a ingresar: ");
            int n = int.Parse(Console.ReadLine());
            int[] edades = new int[n];
            string[] nombres = new string[n];
            int edadMaxima = 0, edadMinima = 100;
            double desviacionMinima = 0;  
            string nombreMaximo = "nombre", nombreMinimo = "nombre", nombreCercano = "nombre";
            double total = 0, promedioedades = 0, desviacion = 0, desviaciones = 0, desviacionreal = 0;


            for (int i = 0; i < edades.Length; i++)
            {
 
                Console.WriteLine("ingrese su nombre:");
                nombres[i] = Console.ReadLine();
               
                Console.WriteLine("ingrese su edad: ");
                edades[i] = int.Parse(Console.ReadLine());

               
                Console.WriteLine("el total de edad fue: " + total + "años");

                if(edades[i] > edadMaxima)
                {
                    edadMaxima = edades[i];
                    nombreMaximo = nombres[i];
                   
                }
                if(edades[i] < edadMinima)
                {
                    edadMinima = edades[i];
                    nombreMinimo = nombres[i];
                   
                }
                total += edades[i];
                promedioedades = (total / edades.Length);
               
               
               
            }
            for(int i = 0; i < n; i++)
            {

                desviaciones = (((edades[i] - promedioedades) * (edades[i] - promedioedades)) / n);
                desviacionreal += Math.Sqrt(desviaciones);

            }
            for (int i = 0; i < n; i++)
            {
                desviacion = (edades[i] - promedioedades) * (edades[i] - promedioedades);
                if (desviacion < desviacionMinima)
                {
                    desviacionMinima = desviacion;
                    nombreCercano = nombres[i];

                }

            }

                Console.WriteLine(nombreMaximo + " tiene la mayor edad con: " + edadMaxima + "años");
            Console.WriteLine(nombreMinimo + " tiene la menor edad con: " + edadMinima + "años");
            Console.WriteLine("el promedio de edad entre los usuario es de: " + promedioedades + "años");
            Console.WriteLine(" la desviacion fue de: " + desviaciones);
            Console.WriteLine("la persona mas cercana al promedio: " + nombreCercano + "con un desviacion de: " + desviacionMinima + "años");
        }

    }
}

