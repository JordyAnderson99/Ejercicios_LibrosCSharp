using System;

namespace Ejer.Cap4y5{

    public class Ejercicio4_2{

        public static void Potencia(){

            string numero = "",potencia = "";
            int i=0, a = 0, b = 0, acu = 1;

            Console.WriteLine("Digite el Numero");
            numero = Console.ReadLine();
            a = Convert.ToInt32(numero);
            Console.WriteLine("Digite la Potencia");
            potencia = Console.ReadLine();
            b = Convert.ToInt32(potencia);

            do
            {            
                i++;
                acu = acu * a;
            } while (i != b);
            Console.WriteLine("La Potencia de {0} Es: {1}",a,acu);
        }
    }
}