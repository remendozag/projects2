using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que solicite la carga de un número 
 * entre 0 y 999, y nos muestre un mensaje de cuántos dígitos 
 * tiene el mismo. Finalizar el programa cuando se cargue 
 * el valor 0.
*/
namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            do
            {
                Console.WriteLine("Ingrese un valor entre 0 y 999 :");
                numero = Console.ReadLine();
                Console.WriteLine("El numero tiene " + numero.Length);
            }
            while (int.Parse(numero) != 0);
            Console.ReadKey();
        }
    }
}
