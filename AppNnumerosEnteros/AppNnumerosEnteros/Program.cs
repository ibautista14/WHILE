using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNnumerosEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que lea n numeros y 
             * calcule la cantidad de valores mayores o 
             * iguales a 1000 */

            int cont1, cont2 = 0, valor = 1;

            Console.WriteLine("Programa numeros enteros mayor o igual a 1000");
            Console.WriteLine("Ingrese la cantidad de numeros: ");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 1; cont1 <= valor; cont1++)
            {


            Console.WriteLine("Digitar valor:");
            valor = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero digitado " + cont1 + " es:" + valor);
            if (valor >= 1000)
                {
                    cont2 = cont2 + 1;
                }
 }

            Console.WriteLine("Los numeros mayores a 1000 son:" + cont2);

            Console.ReadKey();
        }
    }
}
