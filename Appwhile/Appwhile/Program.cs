using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una planta que fabrica perfiles de hierro posee
             * un lote de n piezas. Confeccionar un programa
             * que pida ingresar por telcado la cantidad de piezas
             * a procesar y luego ingrese la longitud de cada
             * perfil; sabiendo que la pieza cuya longitud de cada
             * comprendida en el rango de 1.20 y 1.30 son aptas.
             * Imprimir por pantalla la cantidad de piezas aptas
             * que hay en el lote.*/
            int piezas, contador=0;
            float longitud;
            Console.WriteLine("Programa fabrica de perfiles");
            Console.WriteLine("Lea numero de piezas: ");
            piezas=int.Parse(Console.ReadLine());
            while (contador < piezas)
            {
            Console.WriteLine("Lea longitud: ");
            longitud = float.Parse(Console.ReadLine()); 
            if(longitud >= 1.20 && longitud <= 1.30)
            {
                Console.WriteLine("La pieza "+ longitud + " es apta");
                contador++;
            }
            else
            {
                Console.WriteLine("La pieza " + longitud + "no es apta");
                contador++;
            } 
            
          
            }   
 }
}
}