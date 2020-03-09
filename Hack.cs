using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

        /--------------------------------------------------------------------------------------------/

        int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9, 0, 6, 12, 18 };
        int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2, 12, 18, 6, 0 };
        int datoencomun = 0;
        List<int> union = new List<int>();
        List<int> intercepcion = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            for (int j = 0; j < B.Length; j++)
            {
                if (A[i] == B[j])
                {
                    datoencomun = A[i];
                    datoencomun = B[j];
                    intercepcion.Add(datoencomun);
                }
            }
        }
        intercepcion.Sort();
        for (int i = 0; i < intercepcion.Count - 1; i++)
        {
            if (intercepcion[i] == intercepcion[i + 1])
            {
                intercepcion.RemoveAt(i);
                i = 0;
            }
        }
        Console.WriteLine("la intercepcion es: ");
        for (int i = 0; i < intercepcion.Count; i++)
        {
            Console.WriteLine(intercepcion[i] + ",");
        }
        for (int i = 0; i < A.Length; i++)
        {
            union.Add(A[i]);
        }
        for (int i = 0; i < B.Length; i++)
        {
            union.Add(B[i]);
        }
        union.Sort(); /ordenar los datos sin tantas maricaditas/
        for (int i = 0; i < union.Count - 1; i++)
        {
            if (union[i] == union[i + 1])
            {
                union.RemoveAt(i);
                i = 0;
            }
        }
        Console.WriteLine("la union es: ");
        for (int i = 0; i < union.Count; i++)
        {
            Console.WriteLine(union[i] + ",");
        }

    }

    /--------------------------------------------------------------------------------/
    int[] A = { 0, 15, 6, 12, 3, 18, 12, 6, 9 };
        int[] B = { 4, 0, 18, 6, 16, 6, 10, 14, 2, 12, 8, 2 };

        List<int> union = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            union.Add(A[i]);
        }
        for (int i = 0; i < B.Length; i++)
        {
            union.Add(B[i]);
        }
        union.Sort(); /ordenar los datos sin tantas maricaditas/
        for (int i = 0; i < union.Count - 1; i++) /* .count es el equivalente a .lenght en listas*/
        {
            if (union[i] == union[i + 1])
            {
                union.RemoveAt(i);/remover el dato de la lista/
                i = 0;
            }
        }
        for (int i = 0; i < union.Count - 1; i++)
        {
            Console.WriteLine(union[i]+",");
        }

            /-------------------------------------------------------------------------------------------------/

            string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
            double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
            int salida = 0;
            //--------------------------------------------
            //- Abajo de esta línea va su código ---------       
            for (int i = 0; i < nombres.Length; i++)
            {
                if (notas[i] <= 3)
                {
                    salida++;
                }
            }
            //- Arriba de esta línea va su código --------
            return salida;
        
        
        
            string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
            double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
            string[] salida = new string[5];
            //--------------------------------------------
            //- Abajo de esta línea va su código ---------


            for (int k = 0; k < notas.Length; k++)
            {
                for (int j = 0; j < notas.Length - 1; j++)
                    if (notas[j] > notas[j + 1])
                    {
                        double temporal = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = temporal;

                        string temporaln = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = temporaln;
                    }
            }
            for (int i = 0; i < salida.Length; i++)
            {
                salida[i] = nombres[i];
            }
            //- Arriba de esta línea va su código --------
            return salida;
        
        
        
            string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
            double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

            List<string> salida = new List<string>();
            //--------------------------------------------
            //- Abajo de esta línea va su código ---------       
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] <= 3)
                {
                    salida.Add(nombres[i]);
                }
            }

            //- Arriba de esta línea va su código --------
            return salida;
        
            string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
            double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

            List<string> salida = new List<string>();
            //--------------------------------------------
            //- Abajo de esta línea va su código ---------
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i][0] == 'A' || nombres[i][0] == 'E' || nombres[i][0] == 'I' || nombres[i][0] == 'O' || nombres[i][0] == 'U')
                {
                    salida.Add(nombres[i]);
                }
            }


            //- Arriba de esta línea va su código --------
            return salida;
        
    


             /----------------------------------------------------------------------------------------/
             /* añadir algo a una lista*/
              List<string> nombres = new List<string>();
            nombres.Add("isabela");
            nombres.Add("jaime");
            nombres.Add(Console.ReadLine());
            /------------------------------------------------------------------/
            string[] nombresestudiantes = { "isabela", "valentina", "susana" };
            
            for (int i = 0; i < nombresestudiantes.Length; i++)
            {
                int n = nombresestudiantes[i].Length - 1;/* la ultima posicion del nombre*/
                Console.WriteLine(nombresestudiantes[i][n]);/en nombre y coje en especifico la ultima posicion del nombre/
            }
            /---------------------------------------------------------------------/

            /------------------------------------------------------------------------------------/
            string entrada = "the quick brown fox jumps over the lazy dog";
            string salida = "";
            entrada = entrada.ToUpper();/poner en mayuscula/
            string[] palabras = entrada.Split(' ');/* me hace un arreglo con lo que tenia pero me le quita lo que esta en parentesis,
            en este caso los espacios*/
            for (int i =0;i<entrada.Length; i++)
            {
                /una sola letra/
                char letra = entrada[i];
                if (letra == 'a')
                {
                    Console.WriteLine("'a' encontrada en la posicion: " + i);/* me dice donde esta la letra que busco en la frase*/
                    letra = '4';/* me cambia la letra encontrada por un 4*/
                }
                else if (letra == 'e')
                {
                    Console.WriteLine("'a' encontrada en la posicion: " + i);/* me dice donde esta la letra que busco en la frase*/
                    letra = '3';/* me cambia la letra encontrada por un 4*/
                }
                salida += letra;
            }
            Console.WriteLine(entrada);
            Console.WriteLine(salida);

            /-----------------------------------------------------------------------------------------/
            /como buscar una palabra en una oracion/

            /* Console.WriteLine("ingrese una frase porfavor");
             string frase = Console.ReadLine();*/
            string frase = "jaime es una persona muy cansona pero jaime me cae bien";
            frase = frase.ToUpper();
            /*Console.WriteLine("ingrese la palabra que quiere buscar porfavor");
             string palabrabuscada = Console.ReadLine();*/
            string palabraBuscada = "jaime";
            palabraBuscada = palabraBuscada.ToUpper();
            string[] palabras = frase.Split(' ');
            int contador = 0;
            List<int> posicion = new List<int>();

            for (int i = 0; i < palabras.Length/* coje el largo del arreglo*/; i++)
            {
                if (palabras[i] == palabraBuscada)
                {
                    contador++;
                    posicion.Add(i);
                }
            }
            Console.WriteLine("La palabra se repite " + contador + " veces y esta en la posicion ");
            for (int i = 0; i < posicion.Count; i++)
            {
                Console.WriteLine(posicion[i]);
            }
            /--------------------------------------------------------------------------------------/
            /* potencia de algo*/
            double solucion =  Math.Pow(2, 4) +  Math.Pow(2, 3) +  Math.Pow(2, 2) + Math.Pow(2, 1) +  Math.Pow(2, 0);

            /------------------------------------------------------------------------------------------------/
            Random aleatorio = new Random();/como poner algo en aleatorio/
            int errores = 0, numero1 = aleatorio.Next(1, 11), numero2 = aleatorio.Next(1, 11);/como poner algo en aleatoriodefinido/

            Console.WriteLine("si usted es humano por favor realice esta suma: " + numero1 + "+" + numero2);
            double respuesta = double.Parse(Console.ReadLine());
            /verificacion es la inversa de lo que busco/
            while (respuesta != numero1 + numero2)
            {
                errores++;
                if (errores > 2) break;
                numero1 = aleatorio.Next(1, 11);
                numero2 = aleatorio.Next(1, 11);
                Console.WriteLine("si usted es humano por favor realice esta suma: " + numero1 + "+" + numero2);
                respuesta = double.Parse(Console.ReadLine());
            }

            if (errores <= 2)
            {
                int dado1 = 0, dado2 = 0, total = 0, vidas = 3, max = 0, min = 100, jugador = 0;
                double turnos = 0, turnosvida = 0;
                string continuar = "s", nombreminimo = "nadie", nombremaximo = "nadie";

                Console.WriteLine("ingrese el numero de jugadores (min 2 jugadores y max 5 jugadores): ");
                int jugadores = int.Parse(Console.ReadLine());
                /verificacion entre dos variables/
                while ((jugadores <= 1) || (6 <= jugadores))
                {
                    Console.WriteLine("Error, ingrese el numero de jugadores (min 2 jugadores y max 5 jugadores): ");
                    jugadores = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("ingrese su nombre: ");
                string nombrejugador = (Console.ReadLine());

                while (jugador < jugadores)
                {
                    turnos++;
                    turnosvida++;
                    if (turnos != 3)
                    {
                        dado1 = aleatorio.Next(1, 7);
                        Console.WriteLine("este fue su dado:" + dado1);
                        total += dado1;
                    }
                    if (turnos == 3)
                    {
                        dado1 = aleatorio.Next(1, 7);
                        dado2 = aleatorio.Next(1, 7);
                        Console.WriteLine("estos son sus dados:" + dado1 + "," + dado2);
                        if (dado1 == dado2)
                        {
                            vidas++;
                            Console.WriteLine("ganó vida");
                        }

                        total += dado1 + dado2;
                        turnos = 0;
                    }
                    /los pares es con ese cosito de porcentaje/
                    if (turnosvida % 2 == 0)
                    {
                        vidas--;
                        Console.WriteLine("perdió una vida");

                    }
                    Console.WriteLine("este es su total:" + total);
                    Console.WriteLine("esta es su vida:" + vidas);

                    if (vidas == 0)
                    {
                        jugador++;
                        Console.WriteLine("usted ha perdido");
                        break;
                    }

                    if (total > 100)
                    {
                        Console.WriteLine("usted ha ganado");
                        Console.WriteLine("jugadores" + jugador);
                        jugador++;
                        break;
                    }
                    Console.WriteLine("desea continuar?: (s/n)");
                    continuar = Console.ReadLine();
                    /* verificacion de dos variables juntas*/
                    while ((continuar != "s" && continuar != "n"))
                    {
                        Console.WriteLine("por favor ingrese una respuesta valida,¿desea continuar?: (s/n)");
                        continuar = (Console.ReadLine());
                    }
                    if (continuar == "n") break;
                }
                Console.WriteLine("este es su total:" + total + " gracias por jugar");
                while (jugador < jugadores)
                {
                    /jugador min y jugador max con nombre/
                    if (total > max) max = total; nombremaximo = nombrejugador;
                    if (total < min) min = total; nombreminimo = nombrejugador;
                }
                Console.WriteLine("este fue el total maximo:" + max + " felicitaciones" + nombremaximo);
                Console.WriteLine("este fue el total minimo:" + min + " practica mas" + nombreminimo);
            }
            else Console.WriteLine("lo siento ha agotado su numero de equivocaciones");


            /-----------------------------------------------------------------------------------------------/
            int a = 0, r = 0;
            double[] coordsx = { 0, 1, 2, 3 };
            double[] coordsy = { 0, 1, 2, 3 };
            double[] pendiente = new double[4];
            double[] distancia = new double[12];
            double[] cortey = new double[4];
            double distanciamayor = 0;
            bool pendientesiguales = false, cortesiguales = false;
            for (int i = 0; i < 3; i++)
            {
                pendiente[i] = ((coordsy[i + 1] - coordsy[i]) / (coordsx[i + 1] - coordsx[i]));
                Console.WriteLine("Pendiente entre " + coordsx[i] + "," + coordsx[i] + " y " + coordsx[i + 1] + "," + coordsy[i + 1] + " es: " + pendiente[i]);
                cortey[i] = (coordsy[i] - (pendiente[i] * coordsx[i]));
                Console.WriteLine("el corte en y es: " + cortey[i]);
            }
            for (int i = 0; i < 2; i++)
            {
                if (pendiente[i] == pendiente[i + 1]) pendientesiguales = true;
                else
                {
                    pendientesiguales = false;
                    break;
                }
                if (cortey[i] == cortey[i + 1]) cortesiguales = true;
                else
                {
                    cortesiguales = false;
                    break;
                }

            }
            for (int i = 0; i < 12; i++)
            {
                if (r > 3) r = 0;
                if (i % 4 == 0) a++;
                distancia[i] = Math.Abs(Math.Sqrt((Math.Pow((coordsx[r] - coordsx[a]), 2) + (Math.Pow(coordsy[r] - coordsy[a], 2)))));
                if (distancia[i] > distanciamayor) distanciamayor = distancia[i];
                r++;
            }

            if (cortesiguales == true && pendientesiguales == true) Console.WriteLine("Hacen Parte de la misma recta");
            else Console.WriteLine("No hacen parte de la misma recta");
            Console.WriteLine("la distancia mayor fue:" + distanciamayor);

            /---------------------------------------------------------------------------------------/

            int n = 0, edadmayor = 0, edadmenor = 120, totaledades = 0;
            double promedio = 0, desviest = 0, sumdesv = 0, numerito = 100, diferencia = 0;
            string nombremayor = "", nombremenor = "";
            int indice = 0;

            Console.WriteLine("Ingrese el número de datos que tiene: ");
            n = int.Parse(Console.ReadLine());

            int[] edades = new int[n];
            string[] nombress = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona: ");
                nombress[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la edad de la persona: ");
                edades[i] = int.Parse(Console.ReadLine());

                if (edades[i] > edadmayor)
                {
                    edadmayor = edades[i];
                    nombremayor = nombress[i];

                }
                if (edades[i] < edadmenor)
                {
                    edadmenor = edades[i];
                    nombremenor = nombress[i];

                }
                totaledades += edades[i];
            }

            promedio = totaledades / n;
            /* sumatoria para la desviacion*/
            for (int i = 0; i < n; i++)
            {
                sumdesv += Math.Pow((edades[i] - promedio), 2);
                /la que tenga menor desviacion/
                diferencia = Math.Abs(edades[i] - promedio);
                Console.WriteLine(diferencia);
                if (diferencia < numerito)
                {
                    numerito = diferencia;
                    indice = i; /* posicion indice, es decir , al decir que indice es igual a i,
                    me guarda esa i, por lo cual me guarda la posicion, por lo cual al citar el
                    indice en un arreglo, me da la posicion que necesito*/
                }

            }


            desviest = Math.Sqrt(sumdesv / n);
            Console.WriteLine("El mayor se llama " + nombremayor + ", y tiene: " + edadmayor);
            Console.WriteLine("El menor se llama " + nombremenor + ", y tiene: " + edadmenor);
            Console.WriteLine("El promedio de edades es igual a: " + promedio);
            Console.WriteLine("La desviación estándar es igual a: " + desviest);
            Console.WriteLine("El mas cercano al promedio es: " + nombress[indice]);
        }
    }
