using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string valor =" ";

            Console.WriteLine("Digite El Numero");
            valor = Console.ReadLine();
            a = Convert.ToInt32(valor);

            if (a % 2 == 0)
                Console.Write("El Numero es par");
            else
                Console.Write("El Numero es impar");
        }
    }
}
