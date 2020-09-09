using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string opc = "", valor="";
            int a = 0;
            int b = 0, resultado = 0;

            Console.WriteLine("BIENVENIDO AL MENU");
            Console.WriteLine("1-) Perimetro");
            Console.WriteLine("2-) Area");
            Console.WriteLine("Que desea calcular");
            opc = Console.ReadLine();
            a = Convert.ToInt32(opc);

            switch (a)
            {
                case 1:
                
                    Console.WriteLine("Digite el valor de uno de los lados");
                    valor = Console.ReadLine();
                    a = Convert.ToInt32(valor);
                    Console.WriteLine("Digite la cantida de lados");
                    valor = Console.ReadLine();
                    b= Convert.ToInt32(valor);

                    resultado = a * b;
                    Console.WriteLine("El Resultado Es:{0}", resultado);
                    break;

                case 2:
                    Console.WriteLine("Digite el Perimetro de la figura");
                    valor = Console.ReadLine();
                    a = Convert.ToInt32(valor);
                    Console.WriteLine("Digite el Apotema de la figura");
                    valor = Console.ReadLine();
                    b = Convert.ToInt32(valor);

                    resultado = a * b / 2;
                    Console.WriteLine("El Resultado Es:{0}", resultado);
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;

                    
            }
            
        }
    }
}
