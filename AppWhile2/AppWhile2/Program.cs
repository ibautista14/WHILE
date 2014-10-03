using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que solicite la carga de un valor
             *  positivo y nos muestre desde 1 hasta el valor ingresado
             *  *de uno en uno. Ejemplo: Si ingresamos 30 se debe 
             *  *mostrar en pantalla los numeros de 1 al 30.*/
            int valor, contador = 1;
            Console.WriteLine("Programa valor ingresado");
            Console.WriteLine("Digite valor:");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
         {
                Console.WriteLine(contador);
                contador++;
        }
            Console.ReadKey();
    }
    }
}
