using System;

namespace CicloMientrasNumerosComprendidosEntre2
{
    public class CicloMientrasNumerosComprendidosEntre2
    {
        static void Main(string[] args)
        {
            int num1, num2, aux=0, sw=1, enumerador=1, acumulador;
            string message1, message2, header1, header2;

            message1 = ("Por favor ingrese su primer número:");
            message2 = ("Por favor ingrese su segundo número:");
            header1 = ("***************************************************************");
            header2 = ("* ALGORITMO PARA MOSTRAR NÚMEROS COMPRENDIDOS ENTRE 2 NÚMEROS *");

            Console.WriteLine(header1);
            Console.WriteLine(header2);
            Console.WriteLine(header1);
            Console.WriteLine(message1);
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(message2);
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                aux = num1;
                num1 = num2;
                num2 = aux;
            }

            acumulador = num1;

            Console.WriteLine($"Posición {enumerador} : {num1}");

            while( sw == 1 )
            {
                acumulador++;
                enumerador++;
                if (acumulador == num2)
                {
                    sw = 0;
                }
                else 
                {
                    sw = 1;
                }

                Console.WriteLine($"Posición {enumerador} : {acumulador}");
            }
        }
    }
}
