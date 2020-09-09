using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0, c = 0, resultado = 0;
            string valor = "";
            Console.WriteLine("Conversion de dolar y euros");
            Console.WriteLine("Digite el valor del Dolar");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);

            Console.WriteLine("Digite el valor del Euro");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);

            Console.WriteLine("Digite la cantidad a Cambiar");
            valor = Console.ReadLine();
            c = Convert.ToSingle(valor);

            resultado = a * c;
            Console.WriteLine("La Combersion a Dolar Es: {0}", resultado);
            resultado = b * c;
            Console.WriteLine("La Combersion a Euro Es: {0}", resultado);
            
        }
    }
}
