using System;

namespace LeapYear
{
    public class LeapYear
    {
        static void Main(string[] args)
        {   
            int year, sw=1;
            int multcuatro=4, multcien=100, multcuatrocient=400;

         

            while (sw == 1) 
            {
                Console.WriteLine("****************");
                Console.WriteLine("*Ingrese el año*");
                Console.WriteLine("****************");
                year = Convert.ToInt32(Console.ReadLine());

                if ((year % multcuatrocient == 0) | (year % multcuatro == 0) & (year % multcien != 0))
                {
                    Console.WriteLine($"El año {year} es bisiesto");
                }
                else 
                {
                    Console.WriteLine($"El año {year} no es bisiesto");
                }
                Console.WriteLine("Si desea  ingresar otro año, digite 1 ó 0 para finalizar!");
                sw = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
