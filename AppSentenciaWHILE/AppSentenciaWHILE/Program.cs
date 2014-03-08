using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que solicite la carga de un valor positivo y nos muestre 
 * desde 1 hasta el valor ingresado de uno en uno.Ejemplo: Si ingresamos 30 se 
 * debe mostrar en pantalla los números del 1 al 30.*/

namespace AppSentenciaWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador;
            Console.Write("Digite el numero positivo:");
            numero = int.Parse(Console.ReadLine());
            contador = 0;
            while(contador<30)
            //for (contador = 1; contador <= 30; contador++ )
            {
                contador = contador + 1;
                Console.Write(" " + contador);
            }
            Console.ReadKey();

        }
    }
}
