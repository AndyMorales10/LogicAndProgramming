using System;

namespace Comparacion3Numeros
{   //Ejercicio 3: Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.
    public class Comparacion3Numeros
    {    
        static void Main(string[] args)
        {
            
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Algoritmo para calcular el número mayor de 3 números ingresados");
            Console.WriteLine("***************************************************************");

            double num1, num2, num3, numMayor = 0;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            numMayor = num1;

            if (numMayor < num2) 
            {
                numMayor = num2;
            }

            if (numMayor < num3)
            {
                numMayor = num3;
            }

            Console.WriteLine($"El número mayor es: {numMayor}");

        }
    }
}
