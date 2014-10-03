using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, numero, suma = 0, promedio, contador = 1;
            Console.WriteLine("Programa suma y promedio");
            Console.WriteLine("Digite su numero: ");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
            {
                Console.WriteLine("Digite numero");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                contador++;

            }
            promedio = suma / valor;
            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("El promedio es " + promedio);
            Console.ReadKey();

        }
    }

}



