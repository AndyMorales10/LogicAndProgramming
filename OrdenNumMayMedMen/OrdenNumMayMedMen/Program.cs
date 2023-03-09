using System;

namespace OrdenNumMayMedMen
{
    public class OrdenNumMayMedMen
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            Console.WriteLine("*************************************************");
            Console.WriteLine("*Ingrese 3 números para ordenar de mayor a menor*");
            Console.WriteLine("*************************************************");

            Console.Write("Ingrese el valor del primer número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor del tercer número:");
            num3 = Convert.ToDouble(Console.ReadLine());


            if ((num1 < num2) & (num2 == num3))
            {
                Console.WriteLine("Los números ingresados son iguales");
            }
            else if (num1 < num2)
            {
                if (num2 < num3)
                {
                    Console.WriteLine($"El mayor es: {num3}");
                    Console.WriteLine($"El medio es: {num2}");
                    Console.WriteLine($"El menor es: {num1}");

                }
                else if (num1 < num3)
                {
                    Console.WriteLine($"El mayor es: {num2}");
                    Console.WriteLine($"El medio es: {num3}");
                    Console.WriteLine($"El menor es: {num1}");
                }
                else
                {
                    Console.WriteLine($"El mayor es: {num2}");
                    Console.WriteLine($"El medio es: {num1}");
                    Console.WriteLine($"El menor es: {num3}");
                }
            }
            else if (num1 < num3)
            {
                Console.WriteLine($"El mayor es: {num3}");
                Console.WriteLine($"El medio es: {num1}");
                Console.WriteLine($"El menor es: {num2}");

            }
            else if (num2 < num3)
            {
                Console.WriteLine($"El mayor es: {num1}");
                Console.WriteLine($"El medio es: {num3}");
                Console.WriteLine($"El menor es: {num2}");
            }
            else
            {
                Console.WriteLine($"El mayor es: {num1}");
                Console.WriteLine($"El medio es: {num2}");
                Console.WriteLine($"El menor es: {num3}");

            }
            
        
        }
    }
           
}


        
                
 
        

    
    

