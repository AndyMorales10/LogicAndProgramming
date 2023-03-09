using System;
using System.Data;

namespace CicloMientrasNumPositivoNumNegativo
{
    public class CicloMientrasNumPositivoNumNegativo
    {
        static void Main(string[] args)
        {
            int numIngresado, sw=1, contador=0;
            string message, header1, header2;

            message = ("Por favor ingrese su número:");
            header1 = ("************************************************************");
            header2 = ("* ALGORITMO PARA CAPTURAR LA CANTIDAD DE NÚMEROS POSITIVOS *");

            while (sw==1) 
            {
                Console.WriteLine(header1);
                Console.WriteLine(header2);
                Console.WriteLine(header1);
                Console.WriteLine("");
                Console.WriteLine(message);
                numIngresado = Convert.ToInt32(Console.ReadLine());

                if (numIngresado >= 0)
                {
                    contador++;
                }
                else
                {
                    sw = 0;
                }
                Console.Clear();

            }
            Console.WriteLine(header1);
            Console.WriteLine(header2);
            Console.WriteLine(header1);
            Console.WriteLine("");
            Console.WriteLine($"La cantidad de números positivos ingresados fue de: {contador}");
        }
    }
}
