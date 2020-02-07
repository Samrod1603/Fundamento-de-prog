using System;

namespace tarea_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de votos para partido uno:");
            int votosuno = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de votos para partido dos:");
            int votosdos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de votos en blanco:");
            int votosblanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de votos anulados:");
            int votosanulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese número total de la población de todas las edades:");
            int poblaciont = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese porcentaje de poblacion mayor de edad:");
            double poblacionm = double.Parse(Console.ReadLine());

            int totalvotos = votosuno + votosdos + votosblanco + votosanulados;
            int diferenciavotos = 0;
            if (votosuno - votosdos < 0)
            {
                diferenciavotos = -(votosuno - votosdos); 
            }
            else
            {
                diferenciavotos = votosuno - votosdos; 
            }

            //bool A = false; 
            bool A = (totalvotos > poblaciont);
            //bool B = false;
            bool B = (diferenciavotos < 0.1 * totalvotos);
            //bool C = false; 
            bool C = (totalvotos < 0.3 * poblaciont);

            if ((A || B) && C)
                Console.WriteLine("las elecciones deben ser ejecutadas nuevamente");
            else if (votosuno < votosdos)
                Console.WriteLine("gano el partido dos");
            else if (A == B)
                Console.WriteLine("empate");
            else
                Console.WriteLine("gano el partido uno");
