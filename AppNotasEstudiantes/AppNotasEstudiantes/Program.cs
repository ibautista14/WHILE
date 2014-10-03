using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que lea 10 notas de alumnos y
             * nos informe cuantos tienen notas mayores o iguales a 3
             * y cuantos menos.Para resolver este problema
             * se requieren tres contadores*/

            int cont1, cont2=0, cont3=0, valor = 0;
            float nota;
            Console.WriteLine("Programa notas");
            Console.WriteLine("Digitar el numero de notas:");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 0; cont1 <= valor; cont1++)
            {
                Console.WriteLine("digitar nota:");
                nota = float.Parse(Console.ReadLine());
                Console.WriteLine("La nota" + cont1 + "es:");
                if(nota >= 3)
                {
                   
                 cont2 = cont2 + 1;
                 }
                else
                {
                 cont3 = cont3 + 1;
                }
    }
            Console.WriteLine("digitar notas mayores de 3 son:"+ cont2);
            Console.WriteLine("digitar notas menores de 3 son:"+ cont3);
            Console.ReadKey(); 
}
}

}