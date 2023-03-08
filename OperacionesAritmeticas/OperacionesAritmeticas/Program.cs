using System;

namespace OperacionesAritmeticas
{
    public class OperacionesAritmeticas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones Aritméticas con 2 números");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Ingrese 2 números para calcular la suma, la resta, la división y la multiplicación");
            Console.WriteLine("-------------------------------------");

            int num1, num2, suma, resta, mult;
            double div;
          
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;   
            mult = num1 * num2; 
            div = num1 / num2;

            Console.WriteLine($"El resultado de la suma es: {suma}");
            Console.WriteLine($"El resultado de la resta es: {resta}");
            Console.WriteLine($"El resultado de la multipliación es: {mult}");
            Console.WriteLine($"El resultado de la división es: {div}");
          
        }
    }
}
