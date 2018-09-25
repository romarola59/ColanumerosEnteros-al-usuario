using System;
using System.Collections;

namespace Colaejer.con_numeros_pedidos_al_usuario
{
    public class Program
    {
        public static void Main()
        {
            Double numero = 0, final = 0;
            Queue miCola = new Queue();
            for(byte i = 0; i < 5; i++)
            {
                Console.WriteLine("ingrese un numero Real: ");
                numero = Convert.ToInt32(Console.ReadLine());
                miCola.Enqueue(numero);

            }
            Console.WriteLine("Los numeros reales ingresados son : ");
            for (byte i = 0; i < 5; i++)
            {
                final = (Double)miCola.Dequeue();
                Console.WriteLine(final);
            }
            Console.ReadKey();
        }
    }
        
}
