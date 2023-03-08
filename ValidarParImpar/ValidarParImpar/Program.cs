using System;

namespace ValidarParImpar
{
    public class ValidarParImpar
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El primer número es par: " + num1);
            }
            else
            {
                Console.WriteLine("El primer número es impar: " + num1);
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine("El segundo número es par: " + num2);
            }
            else
            {
                Console.WriteLine("El segundo número es impar: " + num2);
            }
        }
    }
}
