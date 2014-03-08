using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Una planta que fabrica perfiles de hierro posee un lote de n 
 * piezas.Confeccionar un programa que pida ingresar por teclado 
 * la cantidad de piezas a procesar y luego ingrese la longitud de 
 * cada perfil; sabiendo que la pieza cuya longitud esté comprendida
 * en el rango de 1,20 y 1,30 son aptas. Imprimir por pantalla la 
 * cantidad de piezas aptas que hay en el lote.
*/
namespace AppPlanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,contador;
            float longitud;
            contador=1;
            Console.Write("Digite numero piezas: ");
            numero = int.Parse(Console.ReadLine());
            while (contador <= numero)
            {
                Console.WriteLine("Digite longitud de la pieza "+contador+":");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <= 1.30)
                {
                    Console.WriteLine("La pieza "+ contador +" es APTA");
                }
                else
                {
                    Console.WriteLine("La pieza " + contador + " NO es APTA");
                }
                contador = contador + 1;
            }
            Console.ReadKey();

        }
    }
}
