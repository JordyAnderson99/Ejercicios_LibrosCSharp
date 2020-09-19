using System;

namespace Ejer.Cap4y5{

    public class Ejercicio4_1{

        public static void Tabla(){
            
            string num = "";
            int a = 0, acu=1;

            Console.WriteLine("Digite que tabla que desea");
            num = Console.ReadLine();
            a = Convert.ToInt32(num);

            for (int i = 1; i<= 10; i++)
            {
                acu = i* a;
                Console.WriteLine("{0} * {1} = {2}",i,i,acu);
            }

        } 
    }
}