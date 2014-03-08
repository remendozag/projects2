using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sueldos;
            sueldos = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese valor de la componente:");
                sueldos[f] = int.Parse(Console.ReadLine());
            }
            foreach (int s in sueldos)
            {
                Console.WriteLine(s);

            }
            Console.Write("El elemento sueldos[2]:"+sueldos[2]);
            Console.ReadKey();

        }
    }
}
