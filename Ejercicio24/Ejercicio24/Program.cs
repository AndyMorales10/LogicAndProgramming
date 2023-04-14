using System;

namespace Ejercicio24
{
    public class Ejercicio24
    {
        static void Main(string[] args)
        {
            int dias, anios, meses;
            Console.Write("Ingrese un número de días: ");
            dias = Convert.ToInt32(Console.ReadLine());

            anios = CalcularAnios(dias);
            dias = anios * 365;

            meses = CalcularMeses(dias);
            dias = meses * 30;

            MostrarResultado(anios, meses, dias);
        }

        private static int CalcularAnios(int dias)
        {
            return dias / 365;
        }

        private static int CalcularMeses(int dias)
        {
            return dias / 30;
        }

        private static void MostrarResultado(int anios, int meses, int dias)
        {

            Console.WriteLine($"El número ingresado corresponde a: {anios} años, {meses} meses y {dias} días.");

        }
    }
}
