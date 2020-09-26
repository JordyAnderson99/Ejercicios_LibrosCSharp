using System;

namespace Ejer.Cap6y7
{
    class Program{
        static void Main(string[] args){
            int op;
            
            Console.WriteLine("Bienvenido el Menu\n");
            Console.WriteLine("1.Ejercicio2_7");
            Console.WriteLine("2.Ejercicio5_7");
            Console.WriteLine("Elija una opcion");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op){

                case 1:{
                    Console.WriteLine("Diccionario");
                    Ejercicio2_7.Diccionario();
                    break;
                }
                case 2:{
                    Console.WriteLine("Agenda");
                    
                    Ejercicio5_7.Guardar();
                    break;
                }
                

            }
        }
    }
}