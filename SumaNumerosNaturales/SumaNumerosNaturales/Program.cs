using System;

namespace SumaNumerosNaturales
{
    public class SumaNumerosNaturales
    {
        static void Main(string[] args)
        {
            int num, suma, cont;

            cont = 0;
            suma = 0;

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("* ALGORITMO PARA SUMAR LOS NÚMEROS IGUALES E INFERIORES A UN NÚMERO NATURAL INGRESADO *");
            Console.WriteLine("***************************************************************************************");

            Console.WriteLine("Por favor ingrese un número natural: ");
            num = Convert.ToInt32(Console.ReadLine());

            if( num < 0 ) 
            {
                Console.WriteLine("--El número ingresado no es un número natural--");
            }
            else 
            { 
                while( cont <= num ) 
                {
                    suma = suma + cont;
                    cont++;
                }
                Console.WriteLine($"La suma de los números naturales del número ingresado es: {suma}");
            }
        }
    }
}
