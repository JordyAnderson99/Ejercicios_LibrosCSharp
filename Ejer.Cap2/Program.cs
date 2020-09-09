using System;

namespace Ejer.Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor="";
            int a = 0;
            int b = 0, resultado = 0;

            Console.WriteLine("Perimetro de un poligono");
                      
            Console.WriteLine("Digite el valor de uno de los lados");
            valor = Console.ReadLine();
            a = Convert.ToInt32(valor);
            Console.WriteLine("Digite la cantida de lados");
            valor = Console.ReadLine();
            b= Convert.ToInt32(valor);

            resultado = a * b;

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
