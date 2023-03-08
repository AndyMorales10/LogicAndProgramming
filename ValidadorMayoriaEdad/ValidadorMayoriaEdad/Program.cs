using System;

namespace ValidadorMayoriaEdad
{
    public class ValidadorMayoriaEdad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validador de mayoría de edad de las personas");
            Console.WriteLine("--------------------------------------------");

            int edad, mayoriaEdad = 18, sw = 1;

            while (sw == 1)
            {
                Console.WriteLine("Por favor ingrese su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("*** La edad ingresada debe ser mayor a 0 ***");

                }
                else
                {
                    if (edad >= mayoriaEdad)
                    {
                        Console.WriteLine("***Es mayor de edad***");
                    }
                    else
                    {
                        Console.WriteLine("***Es menor de edad***");
                    }

                }
                Console.WriteLine("Digite 1 para verificar otra edad u otro número para salir ");
                sw = Convert.ToInt32(Console.ReadLine());
            }




        }
    }
}
