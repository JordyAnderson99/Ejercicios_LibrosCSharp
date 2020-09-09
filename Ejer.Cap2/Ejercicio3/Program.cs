using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1416f, resultado = 0;
            int a = 0;
            string valor = "";

            Console.WriteLine("De Grados a radianes\n");
            Console.WriteLine("Digite el numero");
            valor = Console.ReadLine();
            a = Convert.ToInt32(valor);

            resultado = a * (pi / 180);

            Console.WriteLine("La Conversion de Grado a Radian Es: {0}",resultado);
        
        }
    }
}
