using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Desarrollar un programa que permita la carga de 10 valores por teclado y 
 * nos muestre posteriormente la suma de los valores ingresados y su promedio.
*/
namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float notas, suma = 0; //promedio;
            int contador;
            contador=1;
            while (contador <= 10)
            {
                Console.WriteLine("Digite nota "+contador);
                notas=float.Parse(Console.ReadLine());
                suma = suma + notas;
                contador=contador+1;
            }
            //promedio = suma / 10;
            Console.WriteLine("El promedio es: " + suma/10);
            Console.ReadKey();

        }
    }
}
