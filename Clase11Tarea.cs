using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDatos
{
    class Program
    {
        static void Main(string[] args)
        {
        }//arreglo de coordenadas 0  1  2  3
        double[] coordenadasX = { 0, 2, 3, 7 };
        double[] coordenadasY = { 0, 1, 5, 6 };
        double[] m = new double[3];
        double[] interceptos = new double[3];

        double mayor = 0;
       

        //Console.WriteLine(coordenadasX[0]+ ","+ coordenadasY[0]);
        //Console.WriteLine(coordenadasX[1] + "," + coordenadasY[1]);
        //Console.WriteLine(coordenadasX[2] + "," + coordenadasY[2]);
        //Console.WriteLine(coordenadasX[3] + "," + coordenadasY[3]);

        //inicio de operaciones ( pendiente, par despues introducir en la ecuacion y = mx +b)
        m[0] = ((coordenadasY[1] - coordenadasY[0]/coordenadas[1] - coordenadas[0]));
        m[1] = ((coordenadasY[2] - coordenadasY[1]/coordenadas[2] - coordenadas[1]));
        m[2] = ((coordenadasY[3] - coordenadasY[2]/coordenadas[3] - coordenadas[2]));
        
        //calculo de interceptos
        interceptos[0] = (coordenadasY - (pendiente[0] * coordenadasX[1])); 
        interceptos[1] = (coordenadasY - (pendiente[1] * coordenadasX[2])); 
        interceptos[2] = (coordenadasY - (pendiente[2] * coordenadasX[3])); 
        
        //calculo de distancias
        double dist = Math.Sqrt((coordenadasx[1] - coordenadasX[0]) * (coordenadas[1] - coordenadas[0]) + (coordenadasY[1] - coordenadasY[0])*(coordenadasY[1] -coordenadasY[0])); 
        double dist2 = Math.Sqrt((coordenadasx[2] - coordenadasX[1]) * (coordenadas[2] - coordenadas[1]) + (coordenadasY[2] - coordenadasY[1])*(coordenadasY[2] -coordenadasY[1])); 
        double dist3 = Math.Sqrt((coordenadasx[3] - coordenadasX[2]) * (coordenadas[3] - coordenadas[2]) + (coordenadasY[3] - coordenadasY[2])*(coordenadasY[3] -coordenadasY[2])); 

        if(dist > mayor)
        {
            mayor = dist;
        }
         if(dist2 > mayor)
        {
            mayor = dist2;
        }
         if(dist3 > mayor)
        {
            mayor = dist3;
        }

        
        
        
        


    }

}

