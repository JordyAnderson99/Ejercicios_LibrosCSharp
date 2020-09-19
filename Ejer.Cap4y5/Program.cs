using System;

namespace Ejer.Cap4y5
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            
            Console.WriteLine("Bienvenido el Menu\n");
            Console.WriteLine("1.Ejercicio4_1");
            Console.WriteLine("2.Ejercicio4_2");
            Console.WriteLine("3.Ejercicio4_5");
            Console.WriteLine("4.Ejercicio5_4");
            Console.WriteLine("5.Ejercicio5_5");
            Console.WriteLine("Elija una opcion");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op){

                case 1:{
                    Console.WriteLine("Tabla de Multiplicar");
                    Ejercicio4_1.Tabla();
                    break;
                }
                case 2:{
                    Console.WriteLine("Elevar un numero a cualquier potencia");
                    Ejercicio4_2.Potencia();
                    break;
                }
                case 3:{
                    Console.WriteLine("Edad Maxima y Minima");
                    Ejercicio4_5.EdadMinYMax();
                    break;
                }
                case 4:{
                    Console.WriteLine("Factorial de un numero");
                    Ejercicio5_4.Factorial();
                    break;
                }
                case 5:{
                    Console.WriteLine("De numero a Cadena");
                    Ejercicio5_5.NumeroCadena();
                    break;
                }

                default:{
                    Console.WriteLine("Esta opcion no existe");
                    break;
                }
            }
        }
    }
}
