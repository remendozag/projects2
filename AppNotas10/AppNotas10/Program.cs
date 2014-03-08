using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Escribir un programa que lea 10 notas de alumnos y nos 
 * informe cuántos tienen notas mayores o iguales a 7 y 
 * cuántos menores.
Para resolver este problema se requieren tres contadores
*/
namespace AppNotas10
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, contador1=0, contador2=0;
            float nota;
            for(contador=1;contador<=10;contador++)
            {
                Console.WriteLine("Digite nota del estudiante "+contador+":");
                nota = float.Parse(Console.ReadLine());
                if (nota >= 7)
                {
                    contador1 = contador1 + 1;
                }
                else 
                {
                    contador2 = contador2 + 1;
                }
               
            }
            Console.WriteLine("Hay " + contador1
                        + " estudiantes con la nota mayor igual a 7");
            Console.WriteLine("Hay " + contador2
                        + " estudiantes con la nota es menor a 7");
            Console.ReadKey();
            
        }
    }
}
