using System;
using System.Collections;

namespace Ejer.Cap6y7{

    public class Ejercicio2_7{
        public static void Diccionario(){
            Hashtable diccionario = new Hashtable();
            int op;
            string palabra, def;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Ingresar paralabra con su definicion");
                Console.WriteLine("2- Buscar Palabra.");
                Console.WriteLine("3- Salir.");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("\nIngrese palabra");
                        palabra = Console.ReadLine();
                        Console.Write("Ingrese Definicion de palabra ingresada");
                        def = Console.ReadLine();
                        diccionario.Add(palabra, def);
                        break;

                    case 2:
                        bool existe = false;

                        Console.Write("Ingrese palabra a buscar");
                        palabra = Console.ReadLine();

                        foreach (DictionaryEntry dato in diccionario)
                        {
                            if (Convert.ToString(dato.Key) == palabra)
                                existe = true;
                        }

                        if (existe == true)
                        {
                            Console.Write("\n{0}:", palabra);
                            Console.WriteLine(diccionario[palabra]);
                        }
                        else
                        {
                            Console.WriteLine("ERROR, Palabra No encontrada.");
                        }

                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        Console.ReadKey();
                        break;
                }
            } while (op != 3);
        }
    }
}