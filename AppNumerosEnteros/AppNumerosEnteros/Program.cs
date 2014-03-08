using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que lea n números enteros y 
 * calcule la cantidad de valores mayores o iguales a 1000.
*/
namespace AppNumerosEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, contador, cantidad, cont1=0, cont2=0;
            Console.Write("Digite Numero:");
            numero = int.Parse(Console.ReadLine());
            for (contador = 1; contador <= numero; contador++)
            {
                Console.Write("Digite cantidad:");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad >= 1000)
                {
                    cont1 = cont1 + 1;
                }
                else
                {
                    cont2 = cont2 + 1;
                }
            }
            Console.WriteLine("Las cantidades mayores o iguales a 1000 son: " + cont1);
            Console.WriteLine("Las cantidades menores a 1000 son: " + cont2);
            Console.ReadKey();

        }
    }
}
